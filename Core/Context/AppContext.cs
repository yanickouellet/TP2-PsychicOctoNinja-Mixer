using DJ.Core.Audio;

namespace DJ.Core.Context
{
    public class AppContext : IContext
    {
        public AudioMaterial MainTrack { get; set; }
        public AudioMaterial SecondaryTrack { get; set; }
    }
}
