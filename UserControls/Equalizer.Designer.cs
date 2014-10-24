namespace DJ.UserControls
{
    partial class Equalizer
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.eq1 = new System.Windows.Forms.TrackBar();
            this.eq5 = new System.Windows.Forms.TrackBar();
            this.eq6 = new System.Windows.Forms.TrackBar();
            this.eq7 = new System.Windows.Forms.TrackBar();
            this.eq4 = new System.Windows.Forms.TrackBar();
            this.eq3 = new System.Windows.Forms.TrackBar();
            this.eq2 = new System.Windows.Forms.TrackBar();
            this.eq8 = new System.Windows.Forms.TrackBar();
            this.eq9 = new System.Windows.Forms.TrackBar();
            this.eq10 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.eq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq10)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eq1
            // 
            this.eq1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.eq1.Location = new System.Drawing.Point(178, 3);
            this.eq1.Maximum = 1000;
            this.eq1.Minimum = -1000;
            this.eq1.Name = "eq1";
            this.eq1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq1.Size = new System.Drawing.Size(29, 195);
            this.eq1.TabIndex = 0;
            this.eq1.Tag = "0";
            this.eq1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq1.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq5
            // 
            this.eq5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.eq5.Location = new System.Drawing.Point(318, 3);
            this.eq5.Maximum = 1000;
            this.eq5.Minimum = -1000;
            this.eq5.Name = "eq5";
            this.eq5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq5.Size = new System.Drawing.Size(29, 195);
            this.eq5.TabIndex = 1;
            this.eq5.Tag = "4";
            this.eq5.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq5.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq6
            // 
            this.eq6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.eq6.Location = new System.Drawing.Point(353, 3);
            this.eq6.Maximum = 1000;
            this.eq6.Minimum = -1000;
            this.eq6.Name = "eq6";
            this.eq6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq6.Size = new System.Drawing.Size(29, 195);
            this.eq6.TabIndex = 2;
            this.eq6.Tag = "5";
            this.eq6.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq6.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq7
            // 
            this.eq7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.eq7.Location = new System.Drawing.Point(388, 3);
            this.eq7.Maximum = 1000;
            this.eq7.Minimum = -1000;
            this.eq7.Name = "eq7";
            this.eq7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq7.Size = new System.Drawing.Size(29, 195);
            this.eq7.TabIndex = 3;
            this.eq7.Tag = "6";
            this.eq7.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq7.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq4
            // 
            this.eq4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.eq4.Location = new System.Drawing.Point(283, 3);
            this.eq4.Maximum = 1000;
            this.eq4.Minimum = -1000;
            this.eq4.Name = "eq4";
            this.eq4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq4.Size = new System.Drawing.Size(29, 195);
            this.eq4.TabIndex = 4;
            this.eq4.Tag = "3";
            this.eq4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq4.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq3
            // 
            this.eq3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.eq3.Location = new System.Drawing.Point(248, 3);
            this.eq3.Maximum = 1000;
            this.eq3.Minimum = -1000;
            this.eq3.Name = "eq3";
            this.eq3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq3.Size = new System.Drawing.Size(29, 195);
            this.eq3.TabIndex = 5;
            this.eq3.Tag = "2";
            this.eq3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq3.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq2
            // 
            this.eq2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.eq2.Location = new System.Drawing.Point(213, 3);
            this.eq2.Maximum = 1000;
            this.eq2.Minimum = -1000;
            this.eq2.Name = "eq2";
            this.eq2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq2.Size = new System.Drawing.Size(29, 195);
            this.eq2.TabIndex = 6;
            this.eq2.Tag = "1";
            this.eq2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq2.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq8
            // 
            this.eq8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.eq8.Location = new System.Drawing.Point(423, 3);
            this.eq8.Maximum = 1000;
            this.eq8.Minimum = -1000;
            this.eq8.Name = "eq8";
            this.eq8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq8.Size = new System.Drawing.Size(29, 195);
            this.eq8.TabIndex = 7;
            this.eq8.Tag = "7";
            this.eq8.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq8.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq9
            // 
            this.eq9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.eq9.Location = new System.Drawing.Point(458, 3);
            this.eq9.Maximum = 1000;
            this.eq9.Minimum = -1000;
            this.eq9.Name = "eq9";
            this.eq9.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq9.Size = new System.Drawing.Size(29, 195);
            this.eq9.TabIndex = 8;
            this.eq9.Tag = "8";
            this.eq9.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq9.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq10
            // 
            this.eq10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.eq10.Location = new System.Drawing.Point(493, 3);
            this.eq10.Maximum = 1000;
            this.eq10.Minimum = -1000;
            this.eq10.Name = "eq10";
            this.eq10.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq10.Size = new System.Drawing.Size(29, 195);
            this.eq10.TabIndex = 9;
            this.eq10.Tag = "9";
            this.eq10.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq10.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.eq3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.eq10, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.eq2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.eq9, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.eq1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.eq8, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.eq4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.eq7, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.eq5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.eq6, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 201);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Equalizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Equalizer";
            this.Size = new System.Drawing.Size(702, 220);
            ((System.ComponentModel.ISupportInitialize)(this.eq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq10)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar eq1;
        private System.Windows.Forms.TrackBar eq5;
        private System.Windows.Forms.TrackBar eq6;
        private System.Windows.Forms.TrackBar eq7;
        private System.Windows.Forms.TrackBar eq4;
        private System.Windows.Forms.TrackBar eq3;
        private System.Windows.Forms.TrackBar eq2;
        private System.Windows.Forms.TrackBar eq8;
        private System.Windows.Forms.TrackBar eq9;
        private System.Windows.Forms.TrackBar eq10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
