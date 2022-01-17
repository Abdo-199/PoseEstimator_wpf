
namespace AutomatischerKamaramann
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Radio_PoseEstimation = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 469);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(3, 476);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(216, 23);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Bitte wählen Sie ein Image Datei aus";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton1.Location = new System.Drawing.Point(463, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gesichte erkennen";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Radio_PoseEstimation
            // 
            this.Radio_PoseEstimation.AutoSize = true;
            this.Radio_PoseEstimation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Radio_PoseEstimation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Radio_PoseEstimation.Location = new System.Drawing.Point(463, 122);
            this.Radio_PoseEstimation.Name = "Radio_PoseEstimation";
            this.Radio_PoseEstimation.Size = new System.Drawing.Size(122, 19);
            this.Radio_PoseEstimation.TabIndex = 3;
            this.Radio_PoseEstimation.TabStop = true;
            this.Radio_PoseEstimation.Text = " Körpern erkennen";
            this.Radio_PoseEstimation.UseVisualStyleBackColor = true;
            this.Radio_PoseEstimation.CheckedChanged += new System.EventHandler(this.Radio_PoseEstimation_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(463, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bitte wählen Sie ein Option aus :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(463, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bitte wählen Sie ein Option aus :";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton3.Location = new System.Drawing.Point(463, 220);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(211, 19);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "alle erkannte Objekte ausschneiden";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton4.Location = new System.Drawing.Point(463, 254);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(152, 19);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ausschnitte auswählen :";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(463, 291);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(149, 23);
            this.iconButton2.TabIndex = 8;
            this.iconButton2.Text = "Nächste Person";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(463, 332);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(149, 23);
            this.iconButton3.TabIndex = 9;
            this.iconButton3.Text = "Person auswählen";
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.Location = new System.Drawing.Point(672, 476);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Radio_PoseEstimation);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(825, 541);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton Radio_PoseEstimation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}
