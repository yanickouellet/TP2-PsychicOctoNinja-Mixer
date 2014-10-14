using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DJ.UserControls
{
    public partial class FileExplorer : UserControl
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void FileExplorer_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;

            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                TreeNode root = new TreeNode(d.Name);
                root.Tag = d.Name; // for later reference
                // TODO: Use Drive image for node

                root.Nodes.Add(new TreeNode()); // add dummy node to allow expansion
                this.trvExplorer.Nodes.Add(root);
            }
        }

        private void AddDirectoriesAndMusicFiles(TreeNode node, string path)
        {
            node.Nodes.Clear(); // clear dummy node if exists

            try
            {
                DirectoryInfo currentDir = new DirectoryInfo(path);
                DirectoryInfo[] subdirs = currentDir.GetDirectories();

                foreach (DirectoryInfo subdir in subdirs)
                {
                    TreeNode child = new TreeNode(subdir.Name);
                    child.Tag = subdir.FullName; // save full path in tag
                    // TODO: Use some image for the node to show its a music file

                    child.Nodes.Add(new TreeNode()); // add dummy node to allow expansion
                    node.Nodes.Add(child);
                }

                List<FileInfo> files = new List<FileInfo>();
                files.AddRange(currentDir.GetFiles("*.mp3"));

                foreach (FileInfo file in files)
                {
                    TreeNode child = new TreeNode(file.Name);
                    // TODO: Use some image for the node to show its a music file

                    child.Tag = file; // save full path for later use
                    node.Nodes.Add(child);
                }

            }
            catch
            { // try to handle use each exception separately
            }
            finally
            {
                node.Tag = null; // clear tag
            }
        }

        private void trvExplorer_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                AddDirectoriesAndMusicFiles(e.Node, (string)e.Node.Tag);
            }
        }

        private void trvExplorer_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Set the drag node and initiate the DragDrop 
            DoDragDrop(e.Item, DragDropEffects.Move);
        }
    }
}
