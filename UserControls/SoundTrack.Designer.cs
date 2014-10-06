namespace DJ.UserControls
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
            this.pgbSpektrum = new System.Windows.Forms.ProgressBar();
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnCue = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
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
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVolume.Size = new System.Drawing.Size(45, 319);
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
            this.panel8.Controls.Add(this.btnLoop);
            this.panel8.Controls.Add(this.btnCue);
            this.panel8.Controls.Add(this.btnPlay);
            this.panel8.Controls.Add(this.btnStop);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 344);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(575, 44);
            this.panel8.TabIndex = 9;
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(123, 6);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(33, 33);
            this.btnLoop.TabIndex = 2;
            this.btnLoop.Text = "Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            // 
            // btnCue
            // 
            this.btnCue.Location = new System.Drawing.Point(45, 6);
            this.btnCue.Name = "btnCue";
            this.btnCue.Size = new System.Drawing.Size(33, 33);
            this.btnCue.TabIndex = 4;
            this.btnCue.Text = "Cue";
            this.btnCue.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(6, 6);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(33, 33);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(84, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(33, 33);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnCue;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
    }
}
