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
        private List<MusiquePlaylist> _playlist;
        private BindingSource _bgsPlaylist;
        private int _indexPlaylist;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public Playlist()
        {
            InitializeComponent();
            _playlist = new List<MusiquePlaylist>();
            _bgsPlaylist = new BindingSource();
            _bgsPlaylist.DataSource = _playlist;
            this.dgvMusic.DataSource = _bgsPlaylist;
        }

        private void Playlist_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Playlist_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be converted to client coordinates.
            var clientPoint = this.dgvMusic.PointToClient(new Point(e.X, e.Y));
            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop = this.dgvMusic.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            var playlistCount = this._playlist.Count;
            int? selectedRowsIndex = rowIndexOfItemUnderMouseToDrop;

            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", true))
            {
                System.IO.FileInfo fileInfo;
                var dropNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                if ((fileInfo = dropNode.Tag as System.IO.FileInfo) != null)
                    AjouterMusique(fileInfo, rowIndexOfItemUnderMouseToDrop);
                else
                    if (!AjouterDossierMusique(dropNode, rowIndexOfItemUnderMouseToDrop))
                        selectedRowsIndex = null;        
            }
            else if (e.Data.GetDataPresent("System.Windows.Forms.DataGridViewRow", true))
            {
                DataGridViewRow rowToMove;
                MusiquePlaylist musique;
                if ((rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow) != null &&
                    ((musique = (MusiquePlaylist)rowToMove.DataBoundItem) != null))
                {
                    this._playlist.Remove(musique);
                    this._playlist.Insert(rowIndexOfItemUnderMouseToDrop != -1 ? rowIndexOfItemUnderMouseToDrop : this._playlist.Count, musique);
                }
                if (selectedRowsIndex == -1) selectedRowsIndex = this._playlist.Count - 1;
            }
            this._bgsPlaylist.ResetBindings(false);

            if (selectedRowsIndex == null) return;
            if (selectedRowsIndex == -1) selectedRowsIndex = (playlistCount == 0 ? 0 : playlistCount);
            this.dgvMusic.Rows[(int)selectedRowsIndex].Selected = true;
            this.dgvMusic.CurrentCell = this.dgvMusic.Rows[(int)selectedRowsIndex].Cells[0];
            this.dgvMusic.Focus();
        }

        private bool AjouterDossierMusique(TreeNode dossier, int position)
        {
            System.IO.FileInfo fileInfo;
            var ajout = false;
            for (var i = 0; i < dossier.Nodes.Count; i++)
                if ((fileInfo = dossier.Nodes[i].Tag as System.IO.FileInfo) != null)
                {
                    AjouterMusique(fileInfo, position + (position == -1 ? 0 : i));
                    ajout = true;
                }
            return ajout;
        }

        private void AjouterMusique(FileInfo file, int position)
        {
            var f = TagLib.File.Create(String.Concat(file.DirectoryName, '\\', file.Name));
            var tag = f.GetTag(TagLib.TagTypes.Id3v2, true);
            var duree = String.Concat(f.Properties.Duration.Minutes, ":", f.Properties.Duration.Seconds, f.Properties.Duration.Seconds.ToString().Length == 1 ? "0" : "");
            var musique = new MusiquePlaylist(tag.Title.Trim(), duree, tag.FirstPerformer, tag.Album, tag.FirstGenre, f);
            if (position == -1)
                _playlist.Add(musique);
            else
                _playlist.Insert(position, musique);
        }

        private void dgvMusic_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != MouseButtons.Left) return;

            // If the mouse moves outside the rectangle, start the drag.
            if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
            {
                // Proceed with the drag and drop, passing in the list item.                    
                var dropEffect = this.dgvMusic.DoDragDrop(this.dgvMusic.Rows[rowIndexFromMouseDown], DragDropEffects.Move);
            }
        }

        private void dgvMusic_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = this.dgvMusic.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                var dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
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
