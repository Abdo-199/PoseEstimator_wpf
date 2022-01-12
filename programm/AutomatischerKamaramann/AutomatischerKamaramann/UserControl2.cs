using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;






namespace AutomatischerKamaramann
{
    public partial class UserControl2 : UserControl
       

    {

        VideoCapture videocapture;
        bool IsPlaying = false;
        int TotalFrames;
        int CurrentFrameNo;
        Mat CurrentFrame;
        int FPS;
        
        public UserControl2()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
              // File path 
                string path = "";
                
                
                // Create open file dialog for opening input video 
           
                    OpenFileDialog fd = new OpenFileDialog(); 
                    //Set the title for file dialog
                    fd.Title = "Bitte wählen Sie eine Videodatei ";
                    // Set the filter
                    fd.Filter = "MP4 Video (*.mp4)|*.mp4|WMV Video (*.wmv)|Quick Movie File (*.mov)|*.mov|";
            //display the file dialog 

            if (fd.ShowDialog() == DialogResult.OK)
            {

                videocapture = new VideoCapture(fd.FileName);
                TotalFrames = Convert.ToInt32(videocapture.Get(Emgu.CV.CvEnum.CapProp.FrameCount));
                TotalFrames = Convert.ToInt32(videocapture.Get(Emgu.CV.CvEnum.CapProp.FrameCount));
                FPS = Convert.ToInt32(videocapture.Get(Emgu.CV.CvEnum.CapProp.Fps));
                IsPlaying = true;
                CurrentFrame = new Mat();
                CurrentFrameNo = 0;
                trackBar1.Minimum = 0;
                trackBar1.Maximum = TotalFrames - 1;
                trackBar1.Value = 0;
                Playvideo();






                // Get the selected file path 
                path = fd.FileName;
                // set the selected imput file path to Textbox`"textbox1"
                textBox1.Text = path;







            }
           
        }
        private async void Playvideo()
            // display inside the picturebox
            
        {
            if (videocapture==null)
            {
                return;
                    
            }
            try
            {
                while (IsPlaying == true && CurrentFrameNo<TotalFrames)
                {
                    videocapture.Set(Emgu.CV.CvEnum.CapProp.PosFrames, CurrentFrameNo);
                    videocapture.Read(CurrentFrame);
                    mp.Image = CurrentFrame.ToBitmap();

                    trackBar1.Value = CurrentFrameNo;
                    CurrentFrameNo += 1;
                    await Task.Delay(100/FPS);





                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (videocapture != null)
            {
                IsPlaying = true;
                Playvideo();
            }
            else
            {
                IsPlaying = false;
            }
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            IsPlaying = false;
           

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {if (videocapture!=null)
            {
                CurrentFrameNo = trackBar1.Value;
            }

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            IsPlaying = false;
            CurrentFrameNo = 0;
            trackBar1.Value = 0;
            mp.Image = null;
            mp.Invalidate();
        }
    }
}
