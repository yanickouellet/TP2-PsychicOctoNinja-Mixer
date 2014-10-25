using System;
using System.Windows.Forms;
using DJ.Core.Controllers;
using DJ.Core.Controllers.Interfaces;

namespace DJ.Winforms
{
    public partial class FrmApp : Form
    {
        private IMainController _mainController;

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
        }

		void _mainController_RaiseVolumeChangedEvent(object sender, Core.Events.VolumeChangedEventArgs e)
		{
			trkMasterVol.Value = e.Level;
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            _mainController.PlayNext();
        }

        private void chkLoop_CheckedChanged(object sender, EventArgs e)
        {
            _mainController.RepeatPlaylist = chkLoop.Checked;
        }

        private void chkShuffle_CheckedChanged(object sender, EventArgs e)
        {
            _mainController.Random = chkShuffle.Checked;
        }
    }
}
