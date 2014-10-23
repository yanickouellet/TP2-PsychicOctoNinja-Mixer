using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using DJ.Core.Audio;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Events;

namespace DJ.UserControls
{
    public partial class SoundTrack : UserControl
    {
        private ITrackController _controller;

        public ITrackController Controller
        {
            get { return _controller; }
            set
            {
                _controller = value;
                if (_controller == null)
                    return;
                Controller.RaiseTrackChangedEvent += Controller_RaiseTrackChangedEvent;
                Controller.RaiseVolumeChangedEvent += ControllerOnRaiseVolumeChangedEvent;
            }
        }

        public SoundTrack()
        {
            InitializeComponent();
        }


        private void trkVolume_Scroll(object sender, System.EventArgs e)
        {
            Controller.SetVolume(trkVolume.Value);
        }

        private void btnStop_Click(object sender, System.EventArgs e)
        {
            Controller.Stop();

            chkPlay.BackColor = SystemColors.AppWorkspace;

            chkPlay.BackgroundImage = ChangeColor((Bitmap)chkPlay.BackgroundImage, "unclick");

            chkPlay.Checked = false;
        }

        private void Controller_RaiseTrackChangedEvent(object sender, TrackChangedEventArgs e)
        {
            if (lblTrackName.InvokeRequired)
            {
                lblTrackName.Invoke(new Action<object, TrackChangedEventArgs>(Controller_RaiseTrackChangedEvent), sender, e);
                return;
            }
            lblTrackName.Text = e.Track.Name;
        }

        private void ControllerOnRaiseVolumeChangedEvent(object sender, VolumeChangedEventArgs e)
        {
            trkVolume.Value = e.Level;
        }

        #region Checkboxes checked changed
        private void btnStop_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundImage = ChangeColor((Bitmap)button.BackgroundImage, "click");
            button.BackColor = Color.MediumBlue;
        }
        private void btnStop_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundImage = ChangeColor((Bitmap)button.BackgroundImage, "unclick");
            button.BackColor = SystemColors.AppWorkspace;
        }
        private void chkPlay_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkPlay.Checked)
            {
            Controller.Play();
            ChangeCheckboxStyle(chkPlay);
        }
        }

        private void chkCue_CheckedChanged(object sender, System.EventArgs e)
        {
            Controller.Cue();
            if (chkCue.Checked)
            {
                chkCue.BackColor = Color.MediumBlue;
                chkCue.ForeColor = Color.White;
            }
            else
            {
                chkCue.BackColor = SystemColors.AppWorkspace;
                chkCue.ForeColor = Color.Black;
            }
        }

        private void chkLoop_CheckedChanged(object sender, System.EventArgs e)
        {
            Controller.Loop = chkLoop.Checked;
            ChangeCheckboxStyle(chkLoop);
        }
        #endregion

        #region Style change for checkboxes
        public void ChangeCheckboxStyle(CheckBox control)
        {
            Bitmap bmp = new Bitmap(control.BackgroundImage);
            if (control.Checked)
            {
                control.BackColor = Color.MediumBlue;
                control.BackgroundImage = ChangeColor((Bitmap)control.BackgroundImage, "click");
            }
            else
            {
                control.BackColor = SystemColors.AppWorkspace;

                control.BackgroundImage = ChangeColor((Bitmap)control.BackgroundImage, "unclick");
            }

        }

        public static Bitmap ChangeColor(Bitmap scrBitmap, string status)
        {
            Color newColor;
            if (status == "click")
            {
                newColor = Color.White;
            }
            else
            {
                newColor = Color.Black;
            }

            Color actulaColor;
            //make an empty bitmap the same size as scrBitmap
            Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    //get the pixel from the scrBitmap image
                    actulaColor = scrBitmap.GetPixel(i, j);
                    // > 150 because.. Images edges can be of low pixel colr. if we set all pixel color to new then there will be no smoothness left.
                    if (actulaColor.A > 150)
                        newBitmap.SetPixel(i, j, newColor);
                    else
                        newBitmap.SetPixel(i, j, actulaColor);
                }
            }
            return newBitmap;
        }
        #endregion

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
    }
}
