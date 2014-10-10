using DJ.Core.Audio;

namespace DJ.Core.Context
{
    public interface IContext
    {
        AudioMaterial MainTrack { get; set; }

        AudioMaterial SecondaryTrack { get; set; }
    }
}
