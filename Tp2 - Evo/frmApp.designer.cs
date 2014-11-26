using DJ.UserControls;

namespace DJ.Winforms
{
    partial class FrmApp
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuVolume = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVolumeAugmenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVolumeDiminuer = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._fileExplorer = new DJ.UserControls.FileExplorer();
            this._playlist = new DJ.UserControls.Playlist();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this._mainTrack = new DJ.UserControls.SoundTrack();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.chkShuffle = new System.Windows.Forms.CheckBox();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTransitions = new System.Windows.Forms.Label();
            this.nudTransitionsTime = new System.Windows.Forms.NumericUpDown();
            this.cboTransitions = new System.Windows.Forms.ComboBox();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.trkMasterVol = new System.Windows.Forms.TrackBar();
            this.lblMaster = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this._secondTrack = new DJ.UserControls.SoundTrack();
            this.tabFileExplorerEqualizer = new System.Windows.Forms.TabControl();
            this.Explorer = new System.Windows.Forms.TabPage();
            this.tabEqualizer = new System.Windows.Forms.TabPage();
            this._equalizer = new DJ.UserControls.Equalizer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransitionsTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkMasterVol)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tabFileExplorerEqualizer.SuspendLayout();
            this.Explorer.SuspendLayout();
            this.tabEqualizer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVolume});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuVolume
            // 
            this.mnuVolume.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVolumeAugmenter,
            this.mnuVolumeDiminuer});
            this.mnuVolume.Name = "mnuVolume";
            this.mnuVolume.Size = new System.Drawing.Size(60, 20);
            this.mnuVolume.Text = "Volume";
            // 
            // mnuVolumeAugmenter
            // 
            this.mnuVolumeAugmenter.Name = "mnuVolumeAugmenter";
            this.mnuVolumeAugmenter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.mnuVolumeAugmenter.Size = new System.Drawing.Size(227, 22);
            this.mnuVolumeAugmenter.Text = "Augmenter";
            this.mnuVolumeAugmenter.Click += new System.EventHandler(this.mnuVolumeAugmenter_Click);
            // 
            // mnuVolumeDiminuer
            // 
            this.mnuVolumeDiminuer.Name = "mnuVolumeDiminuer";
            this.mnuVolumeDiminuer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.mnuVolumeDiminuer.Size = new System.Drawing.Size(227, 22);
            this.mnuVolumeDiminuer.Text = "Dimminuer";
            this.mnuVolumeDiminuer.Click += new System.EventHandler(this.mnuVolumeDiminuer_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(997, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._fileExplorer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._playlist);
            this.splitContainer1.Size = new System.Drawing.Size(977, 257);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 18;
            // 
            // _fileExplorer
            // 
            this._fileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fileExplorer.Location = new System.Drawing.Point(0, 0);
            this._fileExplorer.Name = "_fileExplorer";
            this._fileExplorer.Size = new System.Drawing.Size(254, 257);
            this._fileExplorer.TabIndex = 0;
            // 
            // _playlist
            // 
            this._playlist.Controller = null;
            this._playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this._playlist.Location = new System.Drawing.Point(0, 0);
            this._playlist.Name = "_playlist";
            this._playlist.Size = new System.Drawing.Size(719, 257);
            this._playlist.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabFileExplorerEqualizer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 506);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.35198F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.1943F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.33383F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(991, 202);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 196);
            this.panel1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this._mainTrack);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(374, 196);
            this.panel10.TabIndex = 8;
            // 
            // _mainTrack
            // 
            this._mainTrack.AllowDrop = true;
            this._mainTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._mainTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._mainTrack.Controller = null;
            this._mainTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTrack.Location = new System.Drawing.Point(0, 0);
            this._mainTrack.Name = "_mainTrack";
            this._mainTrack.Size = new System.Drawing.Size(374, 196);
            this._mainTrack.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel5);
            this.panel2.Controls.Add(this.trkMasterVol);
            this.panel2.Controls.Add(this.lblMaster);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(383, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 196);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel12, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(224, 136);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.chkShuffle);
            this.panel12.Controls.Add(this.chkLoop);
            this.panel12.Controls.Add(this.lblTime);
            this.panel12.Controls.Add(this.lblType);
            this.panel12.Controls.Add(this.lblTransitions);
            this.panel12.Controls.Add(this.nudTransitionsTime);
            this.panel12.Controls.Add(this.cboTransitions);
            this.panel12.Controls.Add(this.lblPlaylist);
            this.panel12.Controls.Add(this.btnNext);
            this.panel12.Location = new System.Drawing.Point(1, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(222, 130);
            this.panel12.TabIndex = 2;
            // 
            // chkShuffle
            // 
            this.chkShuffle.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShuffle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.chkShuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkShuffle.BackgroundImage")));
            this.chkShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkShuffle.Location = new System.Drawing.Point(89, 101);
            this.chkShuffle.Name = "chkShuffle";
            this.chkShuffle.Size = new System.Drawing.Size(45, 32);
            this.chkShuffle.TabIndex = 10;
            this.chkShuffle.UseVisualStyleBackColor = false;
            this.chkShuffle.CheckedChanged += new System.EventHandler(this.chkShuffle_CheckedChanged);
            // 
            // chkLoop
            // 
            this.chkLoop.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLoop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.chkLoop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkLoop.BackgroundImage")));
            this.chkLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkLoop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkLoop.Location = new System.Drawing.Point(147, 100);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(45, 32);
            this.chkLoop.TabIndex = 9;
            this.chkLoop.UseVisualStyleBackColor = false;
            this.chkLoop.CheckedChanged += new System.EventHandler(this.chkLoop_CheckedChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(128, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(84, 15);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Duration (sec)";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(43, 27);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(33, 15);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            // 
            // lblTransitions
            // 
            this.lblTransitions.AutoSize = true;
            this.lblTransitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransitions.Location = new System.Drawing.Point(68, 3);
            this.lblTransitions.Name = "lblTransitions";
            this.lblTransitions.Size = new System.Drawing.Size(81, 18);
            this.lblTransitions.TabIndex = 5;
            this.lblTransitions.Text = "Transitions";
            // 
            // nudTransitionsTime
            // 
            this.nudTransitionsTime.Location = new System.Drawing.Point(130, 45);
            this.nudTransitionsTime.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTransitionsTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTransitionsTime.Name = "nudTransitionsTime";
            this.nudTransitionsTime.Size = new System.Drawing.Size(83, 20);
            this.nudTransitionsTime.TabIndex = 4;
            this.nudTransitionsTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTransitionsTime.ValueChanged += new System.EventHandler(this.nudTransitionsTime_ValueChanged);
            // 
            // cboTransitions
            // 
            this.cboTransitions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTransitions.FormattingEnabled = true;
            this.cboTransitions.Items.AddRange(new object[] {
            "Linéaire"});
            this.cboTransitions.Location = new System.Drawing.Point(3, 45);
            this.cboTransitions.Name = "cboTransitions";
            this.cboTransitions.Size = new System.Drawing.Size(121, 21);
            this.cboTransitions.TabIndex = 3;
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.Location = new System.Drawing.Point(86, 78);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(54, 18);
            this.lblPlaylist.TabIndex = 2;
            this.lblPlaylist.Text = "Playlist";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Location = new System.Drawing.Point(24, 99);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(52, 33);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // trkMasterVol
            // 
            this.trkMasterVol.Dock = System.Windows.Forms.DockStyle.Top;
            this.trkMasterVol.Location = new System.Drawing.Point(0, 15);
            this.trkMasterVol.Maximum = 100;
            this.trkMasterVol.Name = "trkMasterVol";
            this.trkMasterVol.Size = new System.Drawing.Size(224, 45);
            this.trkMasterVol.TabIndex = 0;
            this.trkMasterVol.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkMasterVol.ValueChanged += new System.EventHandler(this.trkMasterVol_ValueChanged);
            // 
            // lblMaster
            // 
            this.lblMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaster.Location = new System.Drawing.Point(0, 0);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(224, 15);
            this.lblMaster.TabIndex = 1;
            this.lblMaster.Text = "Master";
            this.lblMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(613, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 196);
            this.panel3.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this._secondTrack);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(375, 196);
            this.panel11.TabIndex = 12;
            // 
            // _secondTrack
            // 
            this._secondTrack.AllowDrop = true;
            this._secondTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._secondTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._secondTrack.Controller = null;
            this._secondTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this._secondTrack.Location = new System.Drawing.Point(0, 0);
            this._secondTrack.Name = "_secondTrack";
            this._secondTrack.Size = new System.Drawing.Size(375, 196);
            this._secondTrack.TabIndex = 0;
            // 
            // tabFileExplorerEqualizer
            // 
            this.tabFileExplorerEqualizer.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabFileExplorerEqualizer.Controls.Add(this.Explorer);
            this.tabFileExplorerEqualizer.Controls.Add(this.tabEqualizer);
            this.tabFileExplorerEqualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFileExplorerEqualizer.Location = new System.Drawing.Point(3, 211);
            this.tabFileExplorerEqualizer.Name = "tabFileExplorerEqualizer";
            this.tabFileExplorerEqualizer.SelectedIndex = 0;
            this.tabFileExplorerEqualizer.Size = new System.Drawing.Size(991, 292);
            this.tabFileExplorerEqualizer.TabIndex = 20;
            // 
            // Explorer
            // 
            this.Explorer.Controls.Add(this.splitContainer1);
            this.Explorer.Location = new System.Drawing.Point(4, 25);
            this.Explorer.Name = "Explorer";
            this.Explorer.Padding = new System.Windows.Forms.Padding(3);
            this.Explorer.Size = new System.Drawing.Size(983, 263);
            this.Explorer.TabIndex = 0;
            this.Explorer.Text = "Explorer";
            this.Explorer.UseVisualStyleBackColor = true;
            // 
            // tabEqualizer
            // 
            this.tabEqualizer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabEqualizer.Controls.Add(this._equalizer);
            this.tabEqualizer.Location = new System.Drawing.Point(4, 25);
            this.tabEqualizer.Name = "tabEqualizer";
            this.tabEqualizer.Padding = new System.Windows.Forms.Padding(3);
            this.tabEqualizer.Size = new System.Drawing.Size(983, 263);
            this.tabEqualizer.TabIndex = 1;
            this.tabEqualizer.Text = "Equalizer";
            // 
            // _equalizer
            // 
            this._equalizer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this._equalizer.Controller = null;
            this._equalizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._equalizer.Location = new System.Drawing.Point(3, 3);
            this._equalizer.Name = "_equalizer";
            this._equalizer.Size = new System.Drawing.Size(977, 257);
            this._equalizer.TabIndex = 0;
            // 
            // FrmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(997, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1013, 591);
            this.Name = "FrmApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PsychicOctoMixer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmApp_FormClosing);
            this.Load += new System.EventHandler(this.FrmApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransitionsTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkMasterVol)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.tabFileExplorerEqualizer.ResumeLayout(false);
            this.Explorer.ResumeLayout(false);
            this.tabEqualizer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trkMasterVol;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private SoundTrack _mainTrack;
        private SoundTrack _secondTrack;
        private FileExplorer _fileExplorer;
        private Playlist _playlist;
        private System.Windows.Forms.TabControl tabFileExplorerEqualizer;
        private System.Windows.Forms.TabPage Explorer;
        private System.Windows.Forms.TabPage tabEqualizer;
        private Equalizer _equalizer;
		private System.Windows.Forms.ToolStripMenuItem mnuVolume;
		private System.Windows.Forms.ToolStripMenuItem mnuVolumeAugmenter;
        private System.Windows.Forms.ToolStripMenuItem mnuVolumeDiminuer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTransitions;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown nudTransitionsTime;
        private System.Windows.Forms.ComboBox cboTransitions;
        private System.Windows.Forms.CheckBox chkLoop;
        private System.Windows.Forms.CheckBox chkShuffle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}

