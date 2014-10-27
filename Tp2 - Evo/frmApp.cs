using System;
using System.Drawing;
using System.Windows.Forms;
using DJ.Core.Controllers;
using DJ.Core.Controllers.Interfaces;
using DJ.UserControls;

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
            cboTransitions.SelectedIndex = 0;
            _mainController.TransitionDuration = (int)nudTransitionsTime.Value;
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
            ChangeCheckboxStyle(chkLoop);
        }

        private void chkShuffle_CheckedChanged(object sender, EventArgs e)
        {
            _mainController.Random = chkShuffle.Checked;
            ChangeCheckboxStyle(chkShuffle);
        }

        private void nudTransitionsTime_ValueChanged(object sender, EventArgs e)
        {
            _mainController.TransitionDuration = (int)nudTransitionsTime.Value;
        }

        #region Style change for checkboxes
        public void ChangeCheckboxStyle(CheckBox control)
        {
            if (control.Checked)
            {
                control.BackColor = Color.MediumBlue;
                control.BackgroundImage = FormHelper.ChangeColor((Bitmap)control.BackgroundImage, "click");
            }
            else
            {
                control.BackColor = SystemColors.AppWorkspace;

                control.BackgroundImage = FormHelper.ChangeColor((Bitmap)control.BackgroundImage, "unclick");
            }

        }
        #endregion
    }
}
