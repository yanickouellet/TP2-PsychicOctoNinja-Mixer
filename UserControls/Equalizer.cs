using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Events;

namespace DJ.UserControls
{
    public partial class Equalizer : UserControl
    {
        public ITrackController Controller{get;set;}
        public Equalizer()
        {
            InitializeComponent();
        }

        private void filter_ValueChanged(object sender, EventArgs e)
        {
            var trackbar = sender as TrackBar;
            if (trackbar != null)
            {
                double perc = (trackbar.Value / (double)trackbar.Maximum);

                //Here the "20" is the maximum decibel values
                var value = (float)(perc * 20);

                //the tag of the trackbar contains the index of the filter
                int filterIndex = Int32.Parse((string)trackbar.Tag);

                Controller.SetFilter(filterIndex, value);

            }
            
        }
    }
}
