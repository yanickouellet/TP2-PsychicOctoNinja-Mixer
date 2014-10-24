using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DJ.Core.Audio;
using DJ.Core.Controllers.Interfaces;

namespace DJ.UserControls
{
    public partial class Playlist : UserControl
    {
        private Core.Audio.Playlist _playlist;
        private BindingSource _bgsPlaylist;
        private Rectangle _dragBoxFromMouseDown;
        private int _rowIndexFromMouseDown;
        private int _rowIndexOfItemUnderMouseToDrop;
        private IPlaylistController _controller;

        public IPlaylistController Controller
        {
            get { return _controller; }
            set
            {
                _controller = value;
                if (_controller == null) return;

                _playlist = _controller.Playlist;
                _bgsPlaylist = new BindingSource { DataSource = _playlist };
                dgvMusic.DataSource = _bgsPlaylist;
            }
        }

        public Playlist()
        {
            InitializeComponent();
        }

        private bool AddMusicFolder(TreeNode folder, int position)
        {
            FileInfo fileInfo;
            var added = false;
            for (var i = 0; i < folder.Nodes.Count; i++)
            {
                if ((fileInfo = folder.Nodes[i].Tag as FileInfo) != null)
                {
                    AddMusic(fileInfo, position + (position == -1 ? 0 : i));
                    added = true;
                }   
            }
            return added;
        }

        private void AddMusic(FileInfo file, int position)
        {
            _playlist.AddItem(file, position);
        }

        private void ChangeSelectedRow(int index)
        {
            if (index < 0 && index >= dgvMusic.Rows.Count) 
                throw new IndexOutOfRangeException();
            dgvMusic.Rows[index].Selected = true;
            dgvMusic.CurrentCell = dgvMusic.Rows[index].Cells[0];
        }

        private void DragDropTreeNode(DragEventArgs e)
        {
            TreeNode dropNode;
            if ((dropNode = e.Data.GetData(typeof (TreeNode)) as TreeNode) == null) return;
            
            FileInfo fileInfo;
            var changeSelectedRow = true;
            var selectedRowIndex = (_rowIndexOfItemUnderMouseToDrop == -1 ? _playlist.Count : _rowIndexOfItemUnderMouseToDrop);

            if ((fileInfo = dropNode.Tag as FileInfo) != null)
                AddMusic(fileInfo, _rowIndexOfItemUnderMouseToDrop);
            else
                changeSelectedRow = AddMusicFolder(dropNode, _rowIndexOfItemUnderMouseToDrop);

            if (!changeSelectedRow) return;
            ChangeSelectedRow(selectedRowIndex);
            dgvMusic.Focus();
        }

        private void DragDropRow(DragEventArgs e)
        {
            DataGridViewRow rowToMove;
            MusicItem music;
            if ((rowToMove = e.Data.GetData(typeof (DataGridViewRow)) as DataGridViewRow) == null ||
                ((music = (MusicItem)rowToMove.DataBoundItem) == null)) return;

            var selectedRowIndex = (_rowIndexOfItemUnderMouseToDrop == -1 ? _playlist.Count - 1 : _rowIndexOfItemUnderMouseToDrop);
            _playlist.Remove(music);
            _playlist.Insert(_rowIndexOfItemUnderMouseToDrop != -1 ? _rowIndexOfItemUnderMouseToDrop : _playlist.Count, music);
            _bgsPlaylist.ResetBindings(false);
            ChangeSelectedRow(selectedRowIndex);
            dgvMusic.Focus();
        }

        private void Playlist_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Playlist_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be converted to client coordinates.
            var clientPoint = dgvMusic.PointToClient(new Point(e.X, e.Y));
            // Get the row index of the item the mouse is below. 
            _rowIndexOfItemUnderMouseToDrop = dgvMusic.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", true))
                DragDropTreeNode(e);
            else if (e.Data.GetDataPresent("System.Windows.Forms.DataGridViewRow", true))
                DragDropRow(e);
        }

        private void dgvMusic_MouseMove(object sender, MouseEventArgs e)
        {
            var hti = dgvMusic.HitTest(e.X, e.Y);
            if (hti.RowIndex > -1 && dgvMusic.SelectedRows[0].Index != hti.RowIndex)
            {
                dgvMusic.ClearSelection();
                dgvMusic.Rows[hti.RowIndex].Selected = true;
            }

            if ((e.Button & MouseButtons.Left) != MouseButtons.Left) return ;

            // If the mouse moves outside the rectangle, start the drag.
            if (_dragBoxFromMouseDown != Rectangle.Empty && !_dragBoxFromMouseDown.Contains(e.X, e.Y))
            {
                // Proceed with the drag and drop, passing in the list item.
                dgvMusic.DoDragDrop(dgvMusic.Rows[_rowIndexFromMouseDown], DragDropEffects.Move);
                dgvMusic.DoDragDrop(dgvMusic.Rows[_rowIndexFromMouseDown], DragDropEffects.Copy);
            }
        }

        private void dgvMusic_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            _rowIndexFromMouseDown = dgvMusic.HitTest(e.X, e.Y).RowIndex;
            if (_rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                var dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                _dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                _dragBoxFromMouseDown = Rectangle.Empty;
        }
    }
}
