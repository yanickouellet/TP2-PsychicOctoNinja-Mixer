﻿namespace DJ.UserControls
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
            this.trvFile = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trvFile
            // 
            this.trvFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvFile.Location = new System.Drawing.Point(0, 0);
            this.trvFile.Name = "trvFile";
            this.trvFile.Size = new System.Drawing.Size(399, 271);
            this.trvFile.TabIndex = 1;
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trvFile);
            this.Name = "FileExplorer";
            this.Size = new System.Drawing.Size(399, 271);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvFile;
    }
}
