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
        Image<Bgr, Byte> emguImage = null;
        Image<Bgr, byte> emguImage1 = null;
        poseEstimation posing = new poseEstimation();
        DetectFace fd = new DetectFace();
        drawing dr = new drawing();
        List<Bitmap> CropsList = new List<Bitmap>();

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
                        emguImage = new Image<Bgr, byte>(filePath);
                        emguImage1 = new Image<Bgr, byte>(filePath);


                        #region resisizing

                        double oldHeight = emguImage.Height;
                        double oldWidth = emguImage.Width;
                        double newHeight = pictureBox1.Height;
                        //to keep the aspect ratio
                        double newWidth = oldWidth * (newHeight / oldHeight);
                        //resizing the width of the PicBox
                        pictureBox1.Width = (int)newWidth; //Muss noch angepasst werden wenn ein Bild zu Breit ist

                        emguImage = emguImage.Resize((int)newWidth, (int)newHeight, Inter.Cubic);
                        emguImage1 = emguImage1.Resize((int)newWidth,(int)newHeight,Inter.Cubic);

                        #endregion

                        pictureBox1.Image = emguImage.ToBitmap();

                        if (PoseEstimationEnabled)
                        {
                            //update the Image to the Image with Rectangles
                            emguImage = dr.drawRect(posing.getPoses(emguImage), emguImage);
                            pictureBox1.Image = emguImage.ToBitmap();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    if (emguImage == null)
                        MessageBox.Show("Bitte Wählen Sie ein Bild aus ");
                    else
                    {
                        emguImage = dr.drawRect(fd.FaceDetIm(emguImage), emguImage);
                        pictureBox1.Image = emguImage.ToBitmap();
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Radio_PoseEstimation_CheckedChanged(object sender, EventArgs e)
        {
            PoseEstimationEnabled = true;
            if (emguImage == null)
            {
                MessageBox.Show("Bitte wählen Sie einen Foto");
            }
            else
            {
                emguImage = dr.drawRect(posing.getPoses(emguImage), emguImage);
                pictureBox1.Image = emguImage.ToBitmap();
            }


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
    }
}

