using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatischerKamaramann
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            {  // File path 
                string path = "";
                try
                {// Create open file dialog for opening input video 

                    OpenFileDialog fd = new OpenFileDialog();
                    //Set the title for file dialog
                    fd.Title = "Bitte wählen Sie ein Video aus ";
                    // Set the filter
                    fd.Filter = "MP4 Video (*.mp4)|*.mp4|WMV Video (*.wmv)|Quick Movie File (*.mov)|*.mov|";
                    //display the file dialog 
                    DialogResult status = fd.ShowDialog();
                    //Verify the whether user selects file or not using DialogRresult constant value 
                    if (status == DialogResult.OK)
                    {// Get the selected file path 
                        path = fd.FileName;
                        // set the selected imput file path to Textbox`"textbox1"
                        textBox1.Text = path;
                       

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
