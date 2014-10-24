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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundTrack));
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.chkCue = new System.Windows.Forms.CheckBox();
            this.chkPlay = new System.Windows.Forms.CheckBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.trkPosition = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.lblTrackName = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPosition)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // trkVolume
            // 
            this.trkVolume.Dock = System.Windows.Forms.DockStyle.Left;
            this.trkVolume.Location = new System.Drawing.Point(0, 0);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVolume.Size = new System.Drawing.Size(45, 342);
            this.trkVolume.SmallChange = 5;
            this.trkVolume.TabIndex = 10;
            this.trkVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkVolume.Scroll += new System.EventHandler(this.trkVolume_Scroll);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnStop);
            this.panel8.Controls.Add(this.chkLoop);
            this.panel8.Controls.Add(this.chkCue);
            this.panel8.Controls.Add(this.chkPlay);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 342);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(573, 44);
            this.panel8.TabIndex = 9;
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
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseDown);
            this.btnStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
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
            // lblArtist
            // 
            this.lblArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(3, 68);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(333, 68);
            this.lblArtist.TabIndex = 21;
            // 
            // trkPosition
            // 
            this.trkPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trkPosition.Location = new System.Drawing.Point(3, 188);
            this.trkPosition.Maximum = 1000;
            this.trkPosition.Name = "trkPosition";
            this.trkPosition.Size = new System.Drawing.Size(522, 45);
            this.trkPosition.TabIndex = 16;
            this.trkPosition.Scroll += new System.EventHandler(this.trkPosition_Scroll);
            this.trkPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trkPosition_MouseDown);
            this.trkPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trkPosition_MouseUp);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblPosition);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.lblLength);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 240);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(522, 54);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(3, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(28, 13);
            this.lblPosition.TabIndex = 18;
            this.lblPosition.Text = "0:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "/";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(55, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(28, 13);
            this.lblLength.TabIndex = 17;
            this.lblLength.Text = "0:00";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.trkPosition, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.44608F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.63625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.75855F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.71304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.44608F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(528, 342);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // picPicture
            // 
            this.picPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPicture.Location = new System.Drawing.Point(342, 3);
            this.picPicture.Name = "picPicture";
            this.tableLayoutPanel3.SetRowSpan(this.picPicture, 2);
            this.picPicture.Size = new System.Drawing.Size(124, 130);
            this.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPicture.TabIndex = 22;
            this.picPicture.TabStop = false;
            // 
            // lblTrackName
            // 
            this.lblTrackName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackName.Location = new System.Drawing.Point(3, 0);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(333, 68);
            this.lblTrackName.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.lblArtist, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblTrackName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.picPicture, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(522, 136);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // SoundTrack
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.trkVolume);
            this.Controls.Add(this.panel8);
            this.Name = "SoundTrack";
            this.Size = new System.Drawing.Size(573, 386);
            this.Load += new System.EventHandler(this.SoundTrack_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SoundTrack_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.SoundTrack_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkPosition)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox chkLoop;
        private System.Windows.Forms.CheckBox chkCue;
        private System.Windows.Forms.CheckBox chkPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TrackBar trkPosition;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.Label lblTrackName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
