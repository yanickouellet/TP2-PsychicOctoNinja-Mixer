using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Observers;

namespace DJ.Winforms
{
    public partial class FrmApp : Form, ITrackObserver
    {
        public ITrackController MainTrackController { get; set; }

        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize,  IntPtr hwndCallback);
        private Mp3 _mixer1;
       
        public FrmApp()
        {
            InitializeComponent();
            //btnPlayMix1.Image = new System.Drawing.Bitmap(Properties.Resources.Play,btnPlayMix1.Width -4, btnPlayMix1.Height-4);
            //btnPauseMix1.Image = new System.Drawing.Bitmap(Properties.Resources.Pause, btnPauseMix1.Width - 4, btnPauseMix1.Height - 4);
            //btnStopMix1.Image = new System.Drawing.Bitmap(Properties.Resources.Stop, btnStopMix1.Width - 4, btnStopMix1.Height - 4);
        }

        private void btnPlayMix1_Click(object sender, EventArgs e)
        {
            _mixer1.Play();
        }

        private void btnPauseMix1_Click(object sender, EventArgs e)
        {
            _mixer1.Pause();
        }

        private void btnStopMix1_Click(object sender, EventArgs e)
        {
            _mixer1.Stop();
        }


        private void ID3Mixer1()
        {
            //if (_mixer1 != null)
            //{
            //    txtAlbum1.Text = _mixer1.Tag.Album;
            //    txtArtiste1.Text = _mixer1.Tag.Artist;
            //    txtDuree1.Text = ((int)(_mixer1.Duration/60)).ToString() + ":" + (_mixer1.Duration % 60).ToString();
            //    txtTitre1.Text = _mixer1.Tag.Title;
            //}
            //else
            //{
            //    txtAlbum1.Text = "";
            //    txtArtiste1.Text = "";
            //    txtDuree1.Text = "";
            //    txtTitre1.Text = "";
            //}
        }


        private void ouvrirUnMp3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                ofd.FileName.EndsWith(".mp3"))
            {
                  if (_mixer1 != null)
                {
                    _mixer1.Close();
                }
                _mixer1 = new Mp3(ofd.FileName);
                ID3Mixer1();
                _mixer1.Open();  
            }
            
        }

        public void SetSpektrum(uint level)
        {
            progressBar1.Value = (int)level;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainTrackController.Play();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MainTrackController.SetVolume((uint)trackBar1.Value * 10);
        }
    }
}
