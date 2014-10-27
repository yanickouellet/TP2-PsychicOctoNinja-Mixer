using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            AllowDrop = true;
            var favoritesNode = new TreeNode("Favoris");

            var favorites = new[] {Environment.SpecialFolder.UserProfile, Environment.SpecialFolder.MyMusic};
            foreach(var favorite in favorites)
            {
                var fullPath = Environment.GetFolderPath(favorite);
                var node = new TreeNode(fullPath.Substring(fullPath.LastIndexOf('\\') + 1));
                AddDirectoriesAndMusicFiles(node, fullPath);
                favoritesNode.Nodes.Add(node);
            }

            trvExplorer.Nodes.Add(favoritesNode);
            foreach (var root in DriveInfo.GetDrives().Select(d => new TreeNode(d.Name) {Tag = d.Name}))
            {
                root.Nodes.Add(new TreeNode());
                trvExplorer.Nodes.Add(root);
            }
        }

        private void AddDirectoriesAndMusicFiles(TreeNode node, string path)
        {
            node.Nodes.Clear(); // clear dummy node if exists

            try
            {
                var currentDir = new DirectoryInfo(path);
                DirectoryInfo[] subdirs = currentDir.GetDirectories();

                foreach (var child in subdirs.Select(subdir => new TreeNode(subdir.Name) {Tag = subdir.FullName}))
                {
                    child.Nodes.Add(new TreeNode()); // add node to allow expansion
                    node.Nodes.Add(child);
                }

                var files = new List<FileInfo>();
                files.AddRange(currentDir.GetFiles("*.mp3"));
                files.AddRange(currentDir.GetFiles("*.m4a"));

                foreach (var child in files.Select(file => new TreeNode(file.Name) {Tag = file}))
                    node.Nodes.Add(child);
            }
            catch (UnauthorizedAccessException)
            { 
                // Exception thrown when unauthorized folder is open. It is ok to catch it and do nothing
                // because the access of certain directories is not allowed in non-admin mode and we do not
                // want to notify the user about it or do something else, it's perfectly normal. Avoid to 
                // do something in this catch will just cause theses forbidden file to not be added to the
                // tree node, wich is exactly the behaviour we want.
            }
            catch (IOException)
            { 
                // Exception thrown when we try to open the CD-ROM node. We do nothing in this catch for 
                // a similar reason than the previous catch. In this case, this exception is thrown when 
                // we try to serach in the CD-ROM drive but no CD-ROM is present.
            }
            finally
            {
                node.Tag = null;
            }
        }

        private void trvExplorer_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag != null) AddDirectoriesAndMusicFiles(e.Node, (string)e.Node.Tag);
        }

        private void trvExplorer_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var node = (TreeNode)e.Item;
            if (node.Tag != null && node.Tag as String != null) 
                AddDirectoriesAndMusicFiles(node, (string)node.Tag);
            // Set the drag node and initiate the DragDrop 
            DoDragDrop(e.Item, DragDropEffects.Move);
        }
    }
}
