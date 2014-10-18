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
        private List<MusicPlaylist> _playlist;
        private BindingSource _bgsPlaylist;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public Playlist()
        {
            InitializeComponent();
            this._playlist = new List<MusicPlaylist>();
            this._bgsPlaylist = new BindingSource();
            this._bgsPlaylist.DataSource = this._playlist;
            this.dgvMusic.DataSource = this._bgsPlaylist;
        }

        private bool AddMusicFolder(TreeNode folder, int position)
        {
            System.IO.FileInfo fileInfo;
            var ajout = false;
            for (var i = 0; i < folder.Nodes.Count; i++)
                if ((fileInfo = folder.Nodes[i].Tag as System.IO.FileInfo) != null)
                {
                    AddMusic(fileInfo, position + (position == -1 ? 0 : i));
                    ajout = true;
                }
            return ajout;
        }

        private void AddMusic(FileInfo file, int position)
        {
            var f = TagLib.File.Create(String.Concat(file.DirectoryName, '\\', file.Name));
            var tag = f.GetTag(TagLib.TagTypes.Id3v2, true) ?? f.GetTag(TagLib.TagTypes.Apple, true);

            if (tag == null) return;
            var duree = String.Concat(f.Properties.Duration.Minutes, ":", f.Properties.Duration.Seconds, f.Properties.Duration.Seconds.ToString().Length == 1 ? "0" : "");
            var musique = new MusicPlaylist(tag.Title.Trim(), duree, tag.FirstPerformer, tag.Album, tag.FirstGenre, f);
            if (position == -1)
                this._playlist.Add(musique);
            else
                this._playlist.Insert(position, musique);
            this._bgsPlaylist.ResetBindings(false);
        }

        private void ChangeSelectedRow(int index)
        {
            if (!(index >= 0 && index < this.dgvMusic.Rows.Count)) 
                throw new IndexOutOfRangeException();
            this.dgvMusic.Rows[index].Selected = true;
            this.dgvMusic.CurrentCell = this.dgvMusic.Rows[index].Cells[0];
        }

        private void DragDropTreeNode(DragEventArgs e)
        {
            TreeNode dropNode;
            if ((dropNode = e.Data.GetData(typeof (TreeNode)) as TreeNode) == null) return;
            
            System.IO.FileInfo fileInfo;
            var changeSelectedRow = true;
            var selectedRowIndex = (rowIndexOfItemUnderMouseToDrop == -1 ? this._playlist.Count : rowIndexOfItemUnderMouseToDrop);

            if ((fileInfo = dropNode.Tag as System.IO.FileInfo) != null)
                AddMusic(fileInfo, rowIndexOfItemUnderMouseToDrop);
            else
                changeSelectedRow = AddMusicFolder(dropNode, rowIndexOfItemUnderMouseToDrop);

            if (!changeSelectedRow) return;
            ChangeSelectedRow(selectedRowIndex);
            this.dgvMusic.Focus();
        }

        private void DragDropRow(DragEventArgs e)
        {
            DataGridViewRow rowToMove;
            MusicPlaylist music;
            if ((rowToMove = e.Data.GetData(typeof (DataGridViewRow)) as DataGridViewRow) == null ||
                ((music = (MusicPlaylist) rowToMove.DataBoundItem) == null)) return;

            var selectedRowIndex = (rowIndexOfItemUnderMouseToDrop == -1 ? this._playlist.Count - 1 : rowIndexOfItemUnderMouseToDrop);
            this._playlist.Remove(music);
            this._playlist.Insert(rowIndexOfItemUnderMouseToDrop != -1 ? rowIndexOfItemUnderMouseToDrop : this._playlist.Count, music);
            this._bgsPlaylist.ResetBindings(false);
            this.ChangeSelectedRow(selectedRowIndex);
            this.dgvMusic.Focus();
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

            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", true))
                DragDropTreeNode(e);
            else if (e.Data.GetDataPresent("System.Windows.Forms.DataGridViewRow", true))
                DragDropRow(e);
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


    public class MusicPlaylist
    {
        public MusicPlaylist(String name, String time, String artist, String album, String genre, TagLib.File audioFile)
        {
            this.Name = name;
            this.Time = time;
            this.Artist = artist;
            this.Album = album;
            this.Genre = genre;
            this.AudioFile = audioFile;
        }

        public String Name { get; set; }
        public String Time { get; set; }
        public String Artist { get; set; }
        public String Album { get; set; }
        public String Genre { get; set; }
        public TagLib.File AudioFile { get; set; }
    }
}
