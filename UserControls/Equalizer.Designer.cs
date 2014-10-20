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
            this.SuspendLayout();
            // 
            // eq1
            // 
            this.eq1.Location = new System.Drawing.Point(33, 28);
            this.eq1.Maximum = 1000;
            this.eq1.Minimum = -1000;
            this.eq1.Name = "eq1";
            this.eq1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq1.Size = new System.Drawing.Size(45, 177);
            this.eq1.TabIndex = 0;
            this.eq1.Tag = "0";
            this.eq1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq1.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq5
            // 
            this.eq5.Location = new System.Drawing.Point(237, 28);
            this.eq5.Maximum = 1000;
            this.eq5.Minimum = -1000;
            this.eq5.Name = "eq5";
            this.eq5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq5.Size = new System.Drawing.Size(45, 177);
            this.eq5.TabIndex = 1;
            this.eq5.Tag = "4";
            this.eq5.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq5.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq6
            // 
            this.eq6.Location = new System.Drawing.Point(288, 28);
            this.eq6.Maximum = 1000;
            this.eq6.Minimum = -1000;
            this.eq6.Name = "eq6";
            this.eq6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq6.Size = new System.Drawing.Size(45, 177);
            this.eq6.TabIndex = 2;
            this.eq6.Tag = "5";
            this.eq6.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq6.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq7
            // 
            this.eq7.Location = new System.Drawing.Point(339, 28);
            this.eq7.Maximum = 1000;
            this.eq7.Minimum = -1000;
            this.eq7.Name = "eq7";
            this.eq7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq7.Size = new System.Drawing.Size(45, 177);
            this.eq7.TabIndex = 3;
            this.eq7.Tag = "6";
            this.eq7.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq7.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq4
            // 
            this.eq4.Location = new System.Drawing.Point(186, 28);
            this.eq4.Maximum = 1000;
            this.eq4.Minimum = -1000;
            this.eq4.Name = "eq4";
            this.eq4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq4.Size = new System.Drawing.Size(45, 177);
            this.eq4.TabIndex = 4;
            this.eq4.Tag = "3";
            this.eq4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq4.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq3
            // 
            this.eq3.Location = new System.Drawing.Point(135, 28);
            this.eq3.Maximum = 1000;
            this.eq3.Minimum = -1000;
            this.eq3.Name = "eq3";
            this.eq3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq3.Size = new System.Drawing.Size(45, 177);
            this.eq3.TabIndex = 5;
            this.eq3.Tag = "2";
            this.eq3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq3.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq2
            // 
            this.eq2.Location = new System.Drawing.Point(84, 28);
            this.eq2.Maximum = 1000;
            this.eq2.Minimum = -1000;
            this.eq2.Name = "eq2";
            this.eq2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq2.Size = new System.Drawing.Size(45, 177);
            this.eq2.TabIndex = 6;
            this.eq2.Tag = "1";
            this.eq2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq2.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq8
            // 
            this.eq8.Location = new System.Drawing.Point(390, 28);
            this.eq8.Maximum = 1000;
            this.eq8.Minimum = -1000;
            this.eq8.Name = "eq8";
            this.eq8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq8.Size = new System.Drawing.Size(45, 177);
            this.eq8.TabIndex = 7;
            this.eq8.Tag = "7";
            this.eq8.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq8.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq9
            // 
            this.eq9.Location = new System.Drawing.Point(441, 28);
            this.eq9.Maximum = 1000;
            this.eq9.Minimum = -1000;
            this.eq9.Name = "eq9";
            this.eq9.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq9.Size = new System.Drawing.Size(45, 177);
            this.eq9.TabIndex = 8;
            this.eq9.Tag = "8";
            this.eq9.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq9.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // eq10
            // 
            this.eq10.Location = new System.Drawing.Point(492, 28);
            this.eq10.Maximum = 1000;
            this.eq10.Minimum = -1000;
            this.eq10.Name = "eq10";
            this.eq10.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq10.Size = new System.Drawing.Size(45, 177);
            this.eq10.TabIndex = 9;
            this.eq10.Tag = "9";
            this.eq10.TickStyle = System.Windows.Forms.TickStyle.None;
            this.eq10.ValueChanged += new System.EventHandler(this.filter_ValueChanged);
            // 
            // Equalizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.eq10);
            this.Controls.Add(this.eq9);
            this.Controls.Add(this.eq8);
            this.Controls.Add(this.eq2);
            this.Controls.Add(this.eq3);
            this.Controls.Add(this.eq4);
            this.Controls.Add(this.eq7);
            this.Controls.Add(this.eq6);
            this.Controls.Add(this.eq5);
            this.Controls.Add(this.eq1);
            this.Name = "Equalizer";
            this.Size = new System.Drawing.Size(572, 231);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
