using System.Windows.Forms;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Observers;

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

        private void btnPlay_Click(object sender, System.EventArgs e)
        {
            Controller.Play();
        }
    }
}
