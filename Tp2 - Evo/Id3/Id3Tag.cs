using System;

namespace DJ.Id3
{
    /// <summary>
    /// Représentation des informations Id3 utiles pour le projet.
    /// <remarks>Ne couvre pas de façon exhaustive la spécification Id3.</remarks>
    /// </summary>
    public struct Id3Tag
    {
        public string Artist;
        public string Album;
        public string Title;
        public Int16 TrackNumber;
        public Int16 AlbumTrackCount;
        public int Id3Size;

        public Id3Tag(string artist, string album, string title, Int16 trackNumber, Int16 albumTrackCount, int id3Size)
        {
            Artist = artist;
            Album = album;
            Title = title;
            TrackNumber = trackNumber;
            AlbumTrackCount = albumTrackCount;
            Id3Size = id3Size;
        }
    }
}
