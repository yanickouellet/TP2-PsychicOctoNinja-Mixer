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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirUnMp3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.thèmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fileExplorer1 = new DJ.UserControls.FileExplorer();
            this.playlist1 = new DJ.UserControls.Playlist();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this._mainTrack = new DJ.UserControls.SoundTrack();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.lblMaster = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this._secondTrack = new DJ.UserControls.SoundTrack();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.thèmeToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirUnMp3ToolStripMenuItem,
            this.toolStripMenuItem3});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // ouvrirUnMp3ToolStripMenuItem
            // 
            this.ouvrirUnMp3ToolStripMenuItem.Name = "ouvrirUnMp3ToolStripMenuItem";
            this.ouvrirUnMp3ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ouvrirUnMp3ToolStripMenuItem.Text = "&Enregistrer";
            this.ouvrirUnMp3ToolStripMenuItem.Click += new System.EventHandler(this.ouvrirUnMp3ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem3.Text = "&Ouvrir";
            // 
            // thèmeToolStripMenuItem
            // 
            this.thèmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerToolStripMenuItem});
            this.thèmeToolStripMenuItem.Name = "thèmeToolStripMenuItem";
            this.thèmeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.thèmeToolStripMenuItem.Text = "&Thème";
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.chargerToolStripMenuItem.Text = "&Charger";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.àProposToolStripMenuItem.Text = "&À propos";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(989, 22);
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
            this.splitContainer1.Panel1.Controls.Add(this.fileExplorer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.playlist1);
            this.splitContainer1.Size = new System.Drawing.Size(969, 175);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 18;
            // 
            // fileExplorer1
            // 
            this.fileExplorer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileExplorer1.Location = new System.Drawing.Point(0, 0);
            this.fileExplorer1.Name = "fileExplorer1";
            this.fileExplorer1.Size = new System.Drawing.Size(252, 175);
            this.fileExplorer1.TabIndex = 0;
            // 
            // playlist1
            // 
            this.playlist1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlist1.Location = new System.Drawing.Point(0, 0);
            this.playlist1.Name = "playlist1";
            this.playlist1.Size = new System.Drawing.Size(713, 175);
            this.playlist1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(989, 443);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.33383F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.33383F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(983, 193);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 187);
            this.panel1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this._mainTrack);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(370, 187);
            this.panel10.TabIndex = 8;
            // 
            // _mainTrack
            // 
            this._mainTrack.Controller = null;
            this._mainTrack.Location = new System.Drawing.Point(3, 3);
            this._mainTrack.Name = "_mainTrack";
            this._mainTrack.Size = new System.Drawing.Size(364, 181);
            this._mainTrack.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.trackBar3);
            this.panel2.Controls.Add(this.trackBar4);
            this.panel2.Controls.Add(this.lblMaster);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(379, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 187);
            this.panel2.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 60);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(223, 67);
            this.panel12.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Crossfade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar3
            // 
            this.trackBar3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar3.Location = new System.Drawing.Point(0, 142);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(223, 45);
            this.trackBar3.TabIndex = 3;
            // 
            // trackBar4
            // 
            this.trackBar4.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar4.Location = new System.Drawing.Point(0, 15);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(223, 45);
            this.trackBar4.TabIndex = 0;
            // 
            // lblMaster
            // 
            this.lblMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaster.Location = new System.Drawing.Point(0, 0);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(223, 15);
            this.lblMaster.TabIndex = 1;
            this.lblMaster.Text = "Master";
            this.lblMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(608, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 187);
            this.panel3.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this._secondTrack);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(372, 187);
            this.panel11.TabIndex = 12;
            // 
            // _secondTrack
            // 
            this._secondTrack.Controller = null;
            this._secondTrack.Location = new System.Drawing.Point(0, -3);
            this._secondTrack.Name = "_secondTrack";
            this._secondTrack.Size = new System.Drawing.Size(375, 190);
            this._secondTrack.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 233);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 207);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 181);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 181);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmApp";
            this.Text = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirUnMp3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem thèmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar3;
        private SoundTrack _mainTrack;
        private SoundTrack _secondTrack;
        private FileExplorer fileExplorer1;
        private Playlist playlist1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

