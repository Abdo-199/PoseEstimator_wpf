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
using VideoToFrames;
using PoseEstimating;
using ApiManager;







namespace AutomatischerKamaramann
{
    public partial class UserControl2 : UserControl
       

    {

        VideoCapture videocapture;
        bool IsPlaying = false;
        int TotalFrames;
        int CurrentFrameNo;
        int FrameWidth;
        int FrameHeight;
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
                    fd.Title = "Bitte wählen Sie ein Video aus ";
                    // Set the filter
                    fd.Filter = "MP4 Video (*.mp4)|*.mp4|WMV Video (*.wmv)|Quick Movie File (*.mov)|*.mov|";
            //display the file dialog 

            if (fd.ShowDialog() == DialogResult.OK)
            {

                videocapture = new VideoCapture(fd.FileName);
                TotalFrames = Convert.ToInt32(videocapture.Get(Emgu.CV.CvEnum.CapProp.FrameCount));

                FPS = Convert.ToInt32(videocapture.Get(Emgu.CV.CvEnum.CapProp.Fps));
                IsPlaying = true;
                CurrentFrame = new Mat();
                CurrentFrameNo = 0;
                trackBar1.Minimum = 0;
                trackBar1.Maximum = TotalFrames - 1;
                trackBar1.Value = 0;
               // Playvideo();
                //#region easier way to play the video and call the Methods
                //inFrames framesGrapper = new inFrames();
                //poseEstimation pose = new poseEstimation();
                //List<Image<Bgr, Byte>> Frames = framesGrapper.vidToFrames(fd.FileName);
                //List<Image<Bgr, Byte>> newFrames = new List<Image<Bgr, byte>>();
                //foreach (Image<Bgr, Byte> Frame in Frames)
                //{
                //    newFrames.Add(pose.getPoses(Frame));
                //}
                //foreach (Image<Bgr, Byte> Frame in newFrames)
                //{
                //    mp.Image = Frame.ToBitmap();
                //    System.Threading.Thread.Sleep(33);
                //    Application.DoEvents();
                //}
                //#endregion
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

        private void BtnSaveVideo_Click(object sender, EventArgs e)
        {
            if (videocapture == null)
                MessageBox.Show("Bitte wählen Sie erstmal ein Video datei aus ");
            else
            {
                BtnPause.PerformClick();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "mp4";
                sfd.AddExtension = true;
                sfd.Filter = "MP4 files|*.mp4";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Mat cframe = new Mat(); //current frame
                        int cfn = 0; //current frame no
                        VideoWriter vwriter = new VideoWriter(sfd.FileName, this.FPS, new Size(this.FrameWidth, this.FrameHeight), true);
                        progressBarSave.Visible = true;
                        progressBarSave.Minimum = cfn;
                        progressBarSave.Maximum = this.TotalFrames;
                        progressBarSave.Value = cfn;
                        this.Cursor = Cursors.WaitCursor;
                        while (cfn < TotalFrames)
                        {
                            videocapture.Set(Emgu.CV.CvEnum.CapProp.PosFrames, cfn);
                            videocapture.Read(cframe);
                            //Image img = cframe.ToBitmap();
                            vwriter.Write(cframe);
                            cfn++;

                            if (cfn < TotalFrames)
                                progressBarSave.Value = cfn;
                        }
                        vwriter.Dispose();
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Video erfolgreich gespeichert.");
                        progressBarSave.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

         }
    }
}
