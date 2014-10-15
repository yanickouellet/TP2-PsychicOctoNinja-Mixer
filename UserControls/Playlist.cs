using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace DJ.UserControls
{
    public partial class Playlist : UserControl
    {
        private List<MusiquePlaylist> playlist;
        private BindingSource bgsPlaylist;

        public Playlist()
        {
            InitializeComponent();
            playlist = new List<MusiquePlaylist>();
            bgsPlaylist = new BindingSource();
            bgsPlaylist.DataSource = playlist;
            this.dgvMusic.DataSource = bgsPlaylist;
        }

        private void Playlist_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Playlist_DragDrop(object sender, DragEventArgs e)
        {
            System.IO.FileInfo fileInfo;
            if (!e.Data.GetDataPresent("System.Windows.Forms.TreeNode", true)) return;          
            var dropNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");
            var targetRow = this.dgvMusic.SelectedRows.Count != 0 ? this.dgvMusic.SelectedRows[0] : null;
            
            if ((fileInfo = dropNode.Tag as System.IO.FileInfo) != null)
                AjouterMusique(fileInfo);
            else
                AjouterDossierMusique(dropNode);

            this.bgsPlaylist.ResetBindings(false);
        }

        private void AjouterDossierMusique(TreeNode dossier)
        {
            System.IO.FileInfo fileInfo;
            foreach (TreeNode node in dossier.Nodes)
                if ((fileInfo = node.Tag as System.IO.FileInfo) != null)
                    AjouterMusique(fileInfo);
        }

        private void AjouterMusique(FileInfo file)
        {
            var f = TagLib.File.Create(String.Concat(file.DirectoryName, '\\', file.Name));
            var tag = f.GetTag(TagLib.TagTypes.Id3v2, true);
            var duree = String.Concat(f.Properties.Duration.Minutes, ":", f.Properties.Duration.Seconds, f.Properties.Duration.Seconds.ToString().Length == 1 ? "0" : "");
            playlist.Add(new MusiquePlaylist(tag.Title.Trim(), duree, tag.FirstPerformer, tag.Album, tag.FirstGenre, f));
        }


    }

    public class MusiquePlaylist
    {
        public MusiquePlaylist(String nom, String duree, String artiste, String album, String genre, TagLib.File fichierMusique)
        {
            this.Nom = nom;
            this.Duree = duree;
            this.Artiste = artiste;
            this.Album = album;
            this.Genre = genre;
            this.FichieMusique = fichierMusique;
        }

        public String Nom { get; set; }
        public String Duree { get; set; }
        public String Artiste { get; set; }
        public String Album { get; set; }
        public String Genre { get; set; }
        public TagLib.File FichieMusique { get; set; }
    }
}
