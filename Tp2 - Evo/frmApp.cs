using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DJ.Core.Controllers;
using DJ.Core.Controllers.Interfaces;

namespace DJ.Winforms
{
    public partial class FrmApp : Form
    {
        private IMainController _mainController;

        private Mp3 _mixer1;
       
        public FrmApp()
        {
            InitializeComponent();

            _mainController = new MainController();
            var mainTrackController = _mainController.CreateMainTrackController();
            _mainTrack.Controller = mainTrackController;
            _equalizer.Controller = mainTrackController;
            _secondTrack.Controller = _mainController.CreateSecondTrackController();
            _playlist.Controller = _mainController.CreatePlaylistController();

			_mainController.RaiseVolumeChangedEvent += _mainController_RaiseVolumeChangedEvent;

            //btnPlayMix1.Image = new System.Drawing.Bitmap(Properties.Resources.Play,btnPlayMix1.Width -4, btnPlayMix1.Height-4);
            //btnPauseMix1.Image = new System.Drawing.Bitmap(Properties.Resources.Pause, btnPauseMix1.Width - 4, btnPauseMix1.Height - 4);
            //btnStopMix1.Image = new System.Drawing.Bitmap(Properties.Resources.Stop, btnStopMix1.Width - 4, btnStopMix1.Height - 4);
        }

		void _mainController_RaiseVolumeChangedEvent(object sender, Core.Events.VolumeChangedEventArgs e)
		{
			trkMasterVol.Value = e.Level;
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

        private void FrmApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainController.Dispose();
        }

        private void FrmApp_Load(object sender, EventArgs e)
        {
            _playlist.AllowDrop = true;
			trkMasterVol.Value = trkMasterVol.Maximum / 2;
        }

		private void trkMasterVol_ValueChanged(object sender, EventArgs e)
		{
			_mainController.ChangeMasterVolume((sender as TrackBar).Value);
		}

		private void mnuVolumeAugmenter_Click(object sender, EventArgs e)
		{
			trkMasterVol.Value++;
		}

		private void mnuVolumeDiminuer_Click(object sender, EventArgs e)
		{
			trkMasterVol.Value--;
		}
    }
}
