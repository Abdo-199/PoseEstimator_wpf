using ApiManager;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using PoseEstimating;
using FaceDetection;
using Croping;




namespace AutomatischerKamaramann
{
    public partial class UserControl1 : UserControl
    {
       
        Image<Bgr, byte> emguImage1 = null;
        poseEstimation posing = new poseEstimation();
        DetectFace fd = new DetectFace();
        drawing dr = new drawing();
        List<Bitmap> CropsList = new List<Bitmap>();
        Image<Bgr, Byte> emguImage_face = null;
        private Image<Bgr, Byte> emguImage_pose = null;

        bool CropEnabled = false;
        bool PoseEstimationEnabled = false;
        bool FaceDetectionEnabled = false;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            try
            {
                using OpenFileDialog ofd = new OpenFileDialog()
                { Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*|Bitmap|*.bmp", ValidateNames = true, Multiselect = false };
                {
                    ofd.Title = "Bitte wählen Sie ein Bild aus";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = ofd.FileName;
                        //e.g. to use the faceDet after the PoseEstm we need to clear the image from the drawn rectangles 
                        //because the clearing of the drawn rectangles needs to make major changes
                        //on the code i found the using of three images will be easier.
                        //to be used with the crops
                        emguImage1 = new Image<Bgr, byte>(filePath);
                        //to be used with face detection
                        emguImage_face = new Image<Bgr, byte>(filePath);
                        // to be used with the pose estimation 
                        emguImage_pose = new Image<Bgr, byte>(filePath);
                        #region resisizing
                        emguImage1 = resize(emguImage1);
                        emguImage_face = resize(emguImage_face);
                        emguImage_pose = resize(emguImage_pose);
                        #endregion
                        pictureBox1.Image = emguImage_face.ToBitmap();
                        //if the radio button was already checked before uploading the photo
                        if (PoseEstimationEnabled)
                        {
                            enablePoseEstimation();
                        }
                        if (FaceDetectionEnabled)
                        {
                            enableFaceDetiction();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Method to resize the Photo and the picBox to keep the original aspect ratio
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        private Image<Bgr, Byte> resize(Image<Bgr, Byte> img)
        {
            double oldHeight = img.Height;
            double oldWidth = img.Width;
            //initiate the process with the picBox height 
            double newHeight = pictureBox1.Height;
            //adjust the width of the image based on the new height and the original aspect ratio
            double newWidth = oldWidth * (newHeight / oldHeight);
            //resizing the width of the PicBox to have the same as the image's
            pictureBox1.Width = (int)newWidth;
            img = img.Resize((int)newWidth, (int)newHeight, Inter.Cubic);
            return img;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Radio_PoseEstimation_CheckedChanged(object sender, EventArgs e)
        {
            


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image == null)
                MessageBox.Show("Bitte wählen Sie ein Bild aus. ");
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPEG files (*.jpeg) |*.jpeg"; //saving files in JPEG Format
                if (DialogResult.OK == sfd.ShowDialog())
                {
                    this.pictureBox1.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("Bild erfolgreich gespeichert.");
                }
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = CropsList[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (AlleObjecteAusschneidenButton.Checked)
            {
                try
                {
                    for (int i = 0; i < fd.facesList.Count; i++)
                    {
                        Bitmap bp = photoCroping.ResizeCrop(emguImage1, fd.facesList[i]);
                        CropsList.Add(bp);
                        //emguImage = bp.ToImage<Bgr, byte>();
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < CropsList.Count; i++)
            {
                if(pictureBox1.Image == CropsList[0])
                    pictureBox1.Image = CropsList[i];   
                return;
            }

            /*if (pictureBox1.Image == CropsList[0])
            {
                pictureBox1.Image = CropsList[1];

            }*/

        }

        private void Radio_PoseEstimation_Click(object sender, EventArgs e)
        {
            PoseEstimationEnabled = true;
            //if the there is no uploaded image
            if (emguImage_pose == null)
            {
                MessageBox.Show("Bitte wählen Sie einen Foto");
            }
            else
            {
               enablePoseEstimation();
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            FaceDetectionEnabled = true;
            if (emguImage_face == null)
            {
                MessageBox.Show("Bitte wählen Sie einen Foto");
            }
            else
            {
                
                enableFaceDetiction();
            }
        }
        /// <summary>
        /// Method to call the pose estimation and th drawing functions
        /// </summary>
        private void enablePoseEstimation()
        {
            //drawRect(List<Rectangle> rectList, Image<Bgr, Byte> currentFrame)
            emguImage_pose = dr.drawRect(posing.getPoses(emguImage_pose), emguImage_pose);
            pictureBox1.Image = emguImage_pose.ToBitmap();
            PoseEstimationEnabled = false;
        }

        private void enableFaceDetiction()
        {
            emguImage_face = dr.drawRect(fd.FaceDetIm(emguImage_face), emguImage_face);
            pictureBox1.Image = emguImage_face.ToBitmap();
            FaceDetectionEnabled = false;
        }
    }
}

