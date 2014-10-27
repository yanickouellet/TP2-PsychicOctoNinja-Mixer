using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DJ.Core.Audio;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Events;

namespace DJ.UserControls
{
    public partial class SoundTrack : UserControl
    {
        private const string TimeFormat = @"mm\:ss";
        private ITrackController _controller;
        private bool _trkPositionDragging;

        public ITrackController Controller
        {
            get { return _controller; }
            set
            {
                _controller = value;
                if (_controller == null)
                    return;
                Controller.TrackChangedEvent += ControllerTrackChangedEvent;
                Controller.VolumeChangedEvent += ControllerOnVolumeChangedEvent;
                Controller.PositionChangedEvent += ControllerOnPositionChangedEvent;
            }
        }

        public SoundTrack()
        {
            InitializeComponent();
            _trkPositionDragging = false;
        }

        #region Style change for checkboxes
        private void ChangeCheckboxStyle(CheckBox control)
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

        #region EVENTS

        private void SoundTrack_Load(object sender, EventArgs e)
        {
            trkVolume.Value = trkVolume.Maximum / 2;
        }

        private void SoundTrack_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void SoundTrack_DragDrop(object sender, DragEventArgs e)
        {
            DataGridViewRow rowToMove;
            MusicItem music;
            if ((rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow) == null ||
                ((music = (MusicItem)rowToMove.DataBoundItem) == null)) return;

            Controller.LoadTrack(music);
            Controller.Play();
        }

        #region Trackbar
        private void trkVolume_Scroll(object sender, System.EventArgs e)
        {
            Controller.SetVolume(trkVolume.Value);
        }

        private void trkPosition_MouseDown(object sender, MouseEventArgs e)
        {
            _trkPositionDragging = true;
        }

        private void trkPosition_MouseUp(object sender, MouseEventArgs e)
        {
            _trkPositionDragging = false;
        }

        private void trkPosition_Scroll(object sender, EventArgs e)
        {
            if (trkPosition.Value >= 0)
                Controller.SetTime(trkPosition.Value);
        }
        #endregion

        #region Buttons and checkboxes
        private void btnStop_Click(object sender, System.EventArgs e)
        {
            Controller.Stop();
            chkPlay.BackColor = SystemColors.AppWorkspace;
            chkPlay.BackgroundImage = FormHelper.ChangeColor((Bitmap)chkPlay.BackgroundImage, "unclick");
            chkPlay.Checked = false;
            chkCue.Checked = false;
        }

        private void btnStop_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundImage = FormHelper.ChangeColor((Bitmap)button.BackgroundImage, "click");
            button.BackColor = Color.MediumBlue;
        }
        private void btnStop_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundImage = FormHelper.ChangeColor((Bitmap)button.BackgroundImage, "unclick");
            button.BackColor = SystemColors.AppWorkspace;
        }
        private void chkPlay_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkPlay.Checked)
            {
                Controller.Play();
                ChangeCheckboxStyle(chkPlay);
                chkCue.Checked = false;
            }
        }

        private void chkCue_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkCue.Checked)
            {
                Controller.Cue();
                chkCue.BackColor = Color.MediumBlue;
                chkCue.ForeColor = Color.White;
            }
            else
            {
                Controller.Play();
                chkCue.BackColor = SystemColors.AppWorkspace;
                chkCue.ForeColor = Color.Black;
            }
        }
        #endregion

        #region ControllerEvents

        private void ControllerOnPositionChangedEvent(object sender, PositionChangedEventArgs e)
        {
            if (trkPosition.InvokeRequired)
            {
                trkPosition.Invoke(new Action<object, PositionChangedEventArgs>(ControllerOnPositionChangedEvent), sender, e);
                return;
            }
            if (!_trkPositionDragging)
                trkPosition.Value = e.Percentage;
            lblPosition.Text = e.Time.ToString(TimeFormat);
        }

        private void ControllerTrackChangedEvent(object sender, TrackChangedEventArgs e)
        {
            if (lblTrackName.InvokeRequired)
            {
                lblTrackName.Invoke(new Action<object, TrackChangedEventArgs>(ControllerTrackChangedEvent), sender, e);
                return;
            }

            chkPlay.Checked = true;
            picPicture.Image = null;
            lblTrackName.Text = e.Track.Name;
            lblLength.Text = Controller.Length.ToString(TimeFormat);
            lblArtist.Text = e.Track.Artist;
            if (e.Track.AudioFile.Tag.Pictures.Length > 0)
            {
                var ms = new MemoryStream(e.Track.AudioFile.Tag.Pictures[0].Data.Data);
                picPicture.Image = Image.FromStream(ms);  
            }
        }
        private void ControllerOnVolumeChangedEvent(object sender, VolumeChangedEventArgs e)
        {
            trkVolume.Value = e.Level;
        }
        #endregion
        #endregion
    }
}
