﻿
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
            this.AlleObjecteAusschneidenButton = new System.Windows.Forms.RadioButton();
            this.AusschnittAuswählenbutton = new System.Windows.Forms.RadioButton();
            this.NächstePersonnButton = new FontAwesome.Sharp.IconButton();
            this.PersonAusButton = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 625);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(3, 635);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(247, 31);
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
            this.radioButton1.Location = new System.Drawing.Point(529, 129);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(162, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gesichter erkennen";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // Radio_PoseEstimation
            // 
            this.Radio_PoseEstimation.AutoSize = true;
            this.Radio_PoseEstimation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Radio_PoseEstimation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Radio_PoseEstimation.Location = new System.Drawing.Point(529, 163);
            this.Radio_PoseEstimation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Radio_PoseEstimation.Name = "Radio_PoseEstimation";
            this.Radio_PoseEstimation.Size = new System.Drawing.Size(159, 24);
            this.Radio_PoseEstimation.TabIndex = 3;
            this.Radio_PoseEstimation.TabStop = true;
            this.Radio_PoseEstimation.Text = " Körpern erkennen";
            this.Radio_PoseEstimation.UseVisualStyleBackColor = true;
            this.Radio_PoseEstimation.CheckedChanged += new System.EventHandler(this.Radio_PoseEstimation_CheckedChanged);
            this.Radio_PoseEstimation.Click += new System.EventHandler(this.Radio_PoseEstimation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(529, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
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
            this.label2.Location = new System.Drawing.Point(529, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bitte wählen Sie ein Option aus :";
            // 
            // AlleObjecteAusschneidenButton
            // 
            this.AlleObjecteAusschneidenButton.AutoSize = true;
            this.AlleObjecteAusschneidenButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlleObjecteAusschneidenButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AlleObjecteAusschneidenButton.Location = new System.Drawing.Point(529, 293);
            this.AlleObjecteAusschneidenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AlleObjecteAusschneidenButton.Name = "AlleObjecteAusschneidenButton";
            this.AlleObjecteAusschneidenButton.Size = new System.Drawing.Size(272, 24);
            this.AlleObjecteAusschneidenButton.TabIndex = 6;
            this.AlleObjecteAusschneidenButton.TabStop = true;
            this.AlleObjecteAusschneidenButton.Text = "alle erkannte Objekte ausschneiden";
            this.AlleObjecteAusschneidenButton.UseVisualStyleBackColor = true;
            this.AlleObjecteAusschneidenButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // AusschnittAuswählenbutton
            // 
            this.AusschnittAuswählenbutton.AutoSize = true;
            this.AusschnittAuswählenbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AusschnittAuswählenbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AusschnittAuswählenbutton.Location = new System.Drawing.Point(529, 339);
            this.AusschnittAuswählenbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AusschnittAuswählenbutton.Name = "AusschnittAuswählenbutton";
            this.AusschnittAuswählenbutton.Size = new System.Drawing.Size(192, 24);
            this.AusschnittAuswählenbutton.TabIndex = 7;
            this.AusschnittAuswählenbutton.TabStop = true;
            this.AusschnittAuswählenbutton.Text = "Ausschnitte auswählen :";
            this.AusschnittAuswählenbutton.UseVisualStyleBackColor = true;
            this.AusschnittAuswählenbutton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // NächstePersonnButton
            // 
            this.NächstePersonnButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.NächstePersonnButton.IconColor = System.Drawing.Color.Black;
            this.NächstePersonnButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NächstePersonnButton.Location = new System.Drawing.Point(529, 388);
            this.NächstePersonnButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NächstePersonnButton.Name = "NächstePersonnButton";
            this.NächstePersonnButton.Size = new System.Drawing.Size(170, 31);
            this.NächstePersonnButton.TabIndex = 8;
            this.NächstePersonnButton.Text = "Nächste Person";
            this.NächstePersonnButton.UseVisualStyleBackColor = true;
            this.NächstePersonnButton.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // PersonAusButton
            // 
            this.PersonAusButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.PersonAusButton.IconColor = System.Drawing.Color.Black;
            this.PersonAusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PersonAusButton.Location = new System.Drawing.Point(529, 443);
            this.PersonAusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonAusButton.Name = "PersonAusButton";
            this.PersonAusButton.Size = new System.Drawing.Size(170, 31);
            this.PersonAusButton.TabIndex = 9;
            this.PersonAusButton.Text = "Person auswählen";
            this.PersonAusButton.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.Location = new System.Drawing.Point(768, 635);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.PersonAusButton);
            this.Controls.Add(this.NächstePersonnButton);
            this.Controls.Add(this.AusschnittAuswählenbutton);
            this.Controls.Add(this.AlleObjecteAusschneidenButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Radio_PoseEstimation);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(943, 721);
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
        private System.Windows.Forms.RadioButton AlleObjecteAusschneidenButton;
        private System.Windows.Forms.RadioButton AusschnittAuswählenbutton;
        private FontAwesome.Sharp.IconButton NächstePersonnButton;
        private FontAwesome.Sharp.IconButton PersonAusButton;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}
