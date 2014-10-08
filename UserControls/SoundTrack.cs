using System.Windows.Forms;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Observers;
using System.Drawing;

namespace DJ.UserControls
{
    public partial class SoundTrack : UserControl, ITrackObserver
    {
        public ITrackController Controller { get; set; }
        public SoundTrack()
        {
            InitializeComponent();
        }

        public void SetSpektrum(uint level)
        {
            pgbSpektrum.Value = (int)level;
        }

        private void trkVolume_Scroll(object sender, System.EventArgs e)
        {
            Controller.SetVolume((uint)trkVolume.Value);
        }


        #region Checkboxes checked changed
        private void chkPlay_CheckedChanged(object sender, System.EventArgs e)
        {
            Controller.Play();
            ChangeCheckboxStyle(this.chkPlay);
        }

        private void chkPause_CheckedChanged(object sender, System.EventArgs e)
        {
            Controller.Stop();
            ChangeCheckboxStyle(this.chkStop);
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
            ChangeCheckboxStyle(this.chkLoop);
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

        
    }
}
