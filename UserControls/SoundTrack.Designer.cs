﻿namespace DJ.UserControls
{
    partial class SoundTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundTrack));
            this.pgbSpektrum = new System.Windows.Forms.ProgressBar();
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.chkCue = new System.Windows.Forms.CheckBox();
            this.chkPlay = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgbSpektrum
            // 
            this.pgbSpektrum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbSpektrum.ForeColor = System.Drawing.Color.DarkRed;
            this.pgbSpektrum.Location = new System.Drawing.Point(45, 0);
            this.pgbSpektrum.Name = "pgbSpektrum";
            this.pgbSpektrum.Size = new System.Drawing.Size(530, 319);
            this.pgbSpektrum.TabIndex = 11;
            this.pgbSpektrum.Value = 50;
            // 
            // trkVolume
            // 
            this.trkVolume.Dock = System.Windows.Forms.DockStyle.Left;
            this.trkVolume.Location = new System.Drawing.Point(0, 0);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVolume.Size = new System.Drawing.Size(45, 319);
            this.trkVolume.SmallChange = 5;
            this.trkVolume.TabIndex = 10;
            this.trkVolume.Scroll += new System.EventHandler(this.trkVolume_Scroll);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(106, 25);
            this.panel7.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(575, 25);
            this.panel4.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnStop);
            this.panel8.Controls.Add(this.btnOpen);
            this.panel8.Controls.Add(this.chkLoop);
            this.panel8.Controls.Add(this.chkCue);
            this.panel8.Controls.Add(this.chkPlay);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 344);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(575, 44);
            this.panel8.TabIndex = 9;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(314, 7);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(51, 30);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Ouvrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // chkLoop
            // 
            this.chkLoop.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLoop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.chkLoop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkLoop.BackgroundImage")));
            this.chkLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkLoop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkLoop.Location = new System.Drawing.Point(207, 6);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(45, 32);
            this.chkLoop.TabIndex = 8;
            this.chkLoop.UseVisualStyleBackColor = false;
            this.chkLoop.CheckedChanged += new System.EventHandler(this.chkLoop_CheckedChanged);
            // 
            // chkCue
            // 
            this.chkCue.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCue.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.chkCue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkCue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkCue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCue.Location = new System.Drawing.Point(9, 6);
            this.chkCue.Name = "chkCue";
            this.chkCue.Size = new System.Drawing.Size(45, 32);
            this.chkCue.TabIndex = 7;
            this.chkCue.Text = "CUE";
            this.chkCue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCue.UseVisualStyleBackColor = false;
            this.chkCue.CheckedChanged += new System.EventHandler(this.chkCue_CheckedChanged);
            // 
            // chkPlay
            // 
            this.chkPlay.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPlay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.chkPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkPlay.BackgroundImage")));
            this.chkPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlay.Location = new System.Drawing.Point(99, 6);
            this.chkPlay.Name = "chkPlay";
            this.chkPlay.Size = new System.Drawing.Size(45, 32);
            this.chkPlay.TabIndex = 5;
            this.chkPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPlay.UseVisualStyleBackColor = false;
            this.chkPlay.CheckedChanged += new System.EventHandler(this.chkPlay_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(54, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(45, 32);
            this.btnStop.TabIndex = 13;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            this.btnStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseDown);
            this.btnStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // SoundTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pgbSpektrum);
            this.Controls.Add(this.trkVolume);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Name = "SoundTrack";
            this.Size = new System.Drawing.Size(575, 388);
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbSpektrum;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox chkLoop;
        private System.Windows.Forms.CheckBox chkCue;
        private System.Windows.Forms.CheckBox chkPlay;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnStop;
    }
}
