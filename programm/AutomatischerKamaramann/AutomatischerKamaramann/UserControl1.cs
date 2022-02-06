using ApiManager;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using PoseEstimating;
using FaceDetection;
using Croping;




namespace AutomatischerKamaramann
{
    public partial class UserControl1 : UserControl
    {
        Image<Bgr, Byte> emguImage = null;
        poseEstimation posing = new poseEstimation();
        DetectFace fd = new DetectFace();

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
                    ofd.Title = "bitte wählen Sie ein Image Datei aus";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {

                        string filePath = ofd.FileName;
                        emguImage = new Image<Bgr, byte>(filePath);

                        #region resisizing

                        double oldHeight = emguImage.Height;
                        double oldWidth = emguImage.Width;
                        double newHeight = pictureBox1.Height;
                        //to keep the aspect ratio
                        double newWidth = oldWidth * (newHeight / oldHeight);
                        //resizing the width of the PicBox
                        pictureBox1.Width = (int)newWidth;
                        emguImage = emguImage.Resize((int)newWidth, (int)newHeight, Inter.Cubic);

                        #endregion



                        
                        pictureBox1.Image = emguImage.ToBitmap();

                        

                        if (FaceDetectionEnabled)//muss noch nach Oben  
                        {
                            //emguImage = faceDetection.FaceDetIm(emguImage);

                            pictureBox1.Image = emguImage.ToBitmap();

                        }
                        
                        if (PoseEstimationEnabled)
                        {
                            //update the Image to the Image with Rectangles
                            emguImage = posing.getPoses(emguImage);
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
            try
            {
                FaceDetectionEnabled = true;
                List<Rectangle> ListFaces = new List<Rectangle>();

               
            }
            catch (Exception exception)
            {
                MessageBox.Show("please select an Image");
                throw;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Radio_PoseEstimation_CheckedChanged(object sender, EventArgs e)
        {
            PoseEstimationEnabled = true;
            pictureBox1.Image = posing.getPoses(emguImage).ToBitmap();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image == null)
                MessageBox.Show("Bitte wählen Sie erstmal ein Video datei aus .");
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPEG files (*.jpeg) |*.jpeg"; //saving files in JPEG Format
                if (DialogResult.OK == sfd.ShowDialog())
                {
                    this.pictureBox1.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("Photo erfolgreich gespeichert.");
                }
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                try
                {

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }

        }
    }
}

