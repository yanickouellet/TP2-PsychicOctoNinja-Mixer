using System.Windows.Forms;
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
            }
        }

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

        private void btnPlay_Click(object sender, System.EventArgs e)
        {
            Controller.Play();
        }

        private void btnStop_Click(object sender, System.EventArgs e)
        {
            Controller.Stop();
        }

        private void btnCue_Click(object sender, System.EventArgs e)
        {
            Controller.Cue();
        }

        public void LoadTrack(string filename)
        {
            Controller.LoadTrack(filename);
        }

        private void Controller_RaiseTrackChangedEvent(object sender, TrackChangedEventArgs e)
        {
        }
    }
}
