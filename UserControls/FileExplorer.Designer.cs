namespace DJ.UserControls
{
    partial class FileExplorer
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
            this.trvExplorer = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trvExplorer
            // 
            this.trvExplorer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trvExplorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvExplorer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trvExplorer.HideSelection = false;
            this.trvExplorer.HotTracking = true;
            this.trvExplorer.LineColor = System.Drawing.Color.Silver;
            this.trvExplorer.Location = new System.Drawing.Point(0, 0);
            this.trvExplorer.Name = "trvExplorer";
            this.trvExplorer.Size = new System.Drawing.Size(353, 355);
            this.trvExplorer.TabIndex = 1;
            this.trvExplorer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvExplorer_BeforeExpand);
            this.trvExplorer.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.trvExplorer_ItemDrag);
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trvExplorer);
            this.Name = "FileExplorer";
            this.Size = new System.Drawing.Size(353, 355);
            this.Load += new System.EventHandler(this.FileExplorer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvExplorer;
    }
}
