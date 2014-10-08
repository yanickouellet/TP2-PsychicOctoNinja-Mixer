using System;
using System.IO;
using System.Text;

namespace DJ.Winforms.Id3
{
    public class V2Extractor : BaseExtractor
    {
        /// <summary>
        /// Extrait un objet DJ.Id3Tag selon la spécification (partielle) d'Id3 v2.
        /// </summary>
        /// <param name="reader">Un reader binaire. Le reader sera lu du début et son pointeur sera déplacé</param>
        /// <returns>Le Id3Tag populé</returns>
        public static Id3Tag Extract(BinaryReader reader)
        {
            return new V2Extractor(reader).Extract();
        }

        private BinaryReader _reader;

        public V2Extractor(BinaryReader reader)
        {
            _reader = reader;
        }

        public override Id3Tag Extract()
        {
            byte flags;
            int ID3Size;
            string trackNum, album, artist, track;
            album = "";
            artist = "";
            track = "";
            trackNum = "";

            _reader.BaseStream.Seek(5, SeekOrigin.Begin);

            flags = _reader.ReadByte();
            ID3Size = DecodeSynchsafe32(_reader.ReadBytes(4));

            // Skip extended header if there's one
            if ((flags & 2) != 0)
                _reader.BaseStream.Seek(DecodeSynchsafe32(_reader.ReadBytes(4)) - 4, SeekOrigin.Current);

            do
            {
                var tmpString = Encoding.ASCII.GetString(_reader.ReadBytes(4));
                switch (tmpString)
                {
                    case "TRCK":
                        trackNum = GetFrameData(_reader);
                        break;
                    case "TALB":
                        album = GetFrameData(_reader);
                        break;
                    case "TPE1":
                        artist = GetFrameData(_reader);
                        break;
                    case "TIT2":
                        track = GetFrameData(_reader);
                        break;
                    default:
                        _reader.BaseStream.Seek(DecodeSynchsafe32(_reader.ReadBytes(4)) + 2, SeekOrigin.Current);
                        break;
                }
            } while (_reader.BaseStream.Position < ID3Size);

            if (trackNum.Contains("/"))
            {
                return new Id3Tag(
                    artist,
                    album,
                    track,
                    Convert.ToInt16(trackNum.Substring(0, trackNum.IndexOf('/'))),
                    Convert.ToInt16(trackNum.Substring(trackNum.IndexOf('/') + 1)),
                    ID3Size
                );
            }

            return new Id3Tag(artist, album, track, Convert.ToInt16(trackNum), 0, ID3Size);
        }
    }
}
