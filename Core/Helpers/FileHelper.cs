using System;
using System.IO;
using DJ.Core.Audio;

namespace DJ.Core.Helpers
{
    public static class FileHelper
    {
        public static MusicItem CreateMusicItem(FileInfo file)
        {
            var audioFile = TagLib.File.Create(file.FullName);
            var tag = audioFile.GetTag(TagLib.TagTypes.Id3v2, true) ?? audioFile.GetTag(TagLib.TagTypes.Apple, true);

            if (tag == null) return null;
            var length = String.Concat(
                audioFile.Properties.Duration.Minutes, ":",
                audioFile.Properties.Duration.Seconds,
                audioFile.Properties.Duration.Seconds.ToString().Length == 1 ? "0" : ""
                );

            return new MusicItem(tag.Title.Trim(), length, tag.FirstPerformer, tag.Album, tag.FirstGenre, audioFile);
        }
    }
}
