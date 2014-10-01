namespace DJ
{
    partial class Form1
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
            this.btnPlayMix1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuree1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitre1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlbum1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArtiste1 = new System.Windows.Forms.TextBox();
            this.btnPauseMix1 = new System.Windows.Forms.Button();
            this.btnStopMix1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirUnMp3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlayMix1
            // 
            this.btnPlayMix1.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayMix1.FlatAppearance.BorderSize = 0;
            this.btnPlayMix1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayMix1.Location = new System.Drawing.Point(7, 27);
            this.btnPlayMix1.Name = "btnPlayMix1";
            this.btnPlayMix1.Size = new System.Drawing.Size(75, 75);
            this.btnPlayMix1.TabIndex = 10;
            this.btnPlayMix1.UseVisualStyleBackColor = false;
            this.btnPlayMix1.Click += new System.EventHandler(this.btnPlayMix1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Durée :";
            // 
            // txtDuree1
            // 
            this.txtDuree1.Enabled = false;
            this.txtDuree1.Location = new System.Drawing.Point(78, 186);
            this.txtDuree1.Name = "txtDuree1";
            this.txtDuree1.Size = new System.Drawing.Size(63, 20);
            this.txtDuree1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Titre :";
            // 
            // txtTitre1
            // 
            this.txtTitre1.Enabled = false;
            this.txtTitre1.Location = new System.Drawing.Point(78, 108);
            this.txtTitre1.Name = "txtTitre1";
            this.txtTitre1.Size = new System.Drawing.Size(160, 20);
            this.txtTitre1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Album :";
            // 
            // txtAlbum1
            // 
            this.txtAlbum1.Enabled = false;
            this.txtAlbum1.Location = new System.Drawing.Point(78, 160);
            this.txtAlbum1.Name = "txtAlbum1";
            this.txtAlbum1.Size = new System.Drawing.Size(160, 20);
            this.txtAlbum1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Artiste :";
            // 
            // txtArtiste1
            // 
            this.txtArtiste1.Enabled = false;
            this.txtArtiste1.Location = new System.Drawing.Point(78, 134);
            this.txtArtiste1.Name = "txtArtiste1";
            this.txtArtiste1.Size = new System.Drawing.Size(160, 20);
            this.txtArtiste1.TabIndex = 0;
            // 
            // btnPauseMix1
            // 
            this.btnPauseMix1.BackColor = System.Drawing.Color.Transparent;
            this.btnPauseMix1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPauseMix1.FlatAppearance.BorderSize = 0;
            this.btnPauseMix1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseMix1.Location = new System.Drawing.Point(103, 27);
            this.btnPauseMix1.Name = "btnPauseMix1";
            this.btnPauseMix1.Size = new System.Drawing.Size(75, 75);
            this.btnPauseMix1.TabIndex = 14;
            this.btnPauseMix1.UseVisualStyleBackColor = false;
            this.btnPauseMix1.Click += new System.EventHandler(this.btnPauseMix1_Click);
            // 
            // btnStopMix1
            // 
            this.btnStopMix1.BackColor = System.Drawing.Color.Transparent;
            this.btnStopMix1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStopMix1.FlatAppearance.BorderSize = 0;
            this.btnStopMix1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopMix1.Location = new System.Drawing.Point(194, 27);
            this.btnStopMix1.Name = "btnStopMix1";
            this.btnStopMix1.Size = new System.Drawing.Size(75, 75);
            this.btnStopMix1.TabIndex = 15;
            this.btnStopMix1.UseVisualStyleBackColor = false;
            this.btnStopMix1.Click += new System.EventHandler(this.btnStopMix1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirUnMp3ToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirUnMp3ToolStripMenuItem
            // 
            this.ouvrirUnMp3ToolStripMenuItem.Name = "ouvrirUnMp3ToolStripMenuItem";
            this.ouvrirUnMp3ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ouvrirUnMp3ToolStripMenuItem.Text = "Ouvrir un Mp3";
            this.ouvrirUnMp3ToolStripMenuItem.Click += new System.EventHandler(this.ouvrirUnMp3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 673);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDuree1);
            this.Controls.Add(this.btnStopMix1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPauseMix1);
            this.Controls.Add(this.txtTitre1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlbum1);
            this.Controls.Add(this.btnPlayMix1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArtiste1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayMix1;
        private System.Windows.Forms.TextBox txtArtiste1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuree1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlbum1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPauseMix1;
        private System.Windows.Forms.Button btnStopMix1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirUnMp3ToolStripMenuItem;
    }
}

