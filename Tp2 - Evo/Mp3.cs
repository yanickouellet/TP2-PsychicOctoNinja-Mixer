using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;
using DJ.Id3;

namespace DJ
{
    public class Mp3NotOpenedException : Exception
    {
        public Mp3NotOpenedException(string msg)
            : base(msg)
        {

        }
    }

    public class InvalidMp3Exception : Exception
    {
        public InvalidMp3Exception(string msg)
            : base(msg)
        {
        }
    }

    public class Mp3 : IMp3
    {
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        private Id3Tag _mp3Info;
        private int _bitrate;
        private int _frequency;
        private bool _VBR;
        private int _MPEG;
        private bool _mono;
        private bool _padding;
        private int _duration;
        private string _path;
        private string _alias;
        private Stopwatch _position;

        public int Duration
        {
            get { return _duration; }
        }

        public Stopwatch Position
        {
            get { return _position; }
        }

        public Id3Tag Tag
        {
            get { return _mp3Info; }
        }

        public Mp3(string path)
        {
            _path = path;
            DecodeMp3();
            _alias = Guid.NewGuid().ToString();
            _position = new Stopwatch();
        }

        public override string ToString()
        {
            return _mp3Info.Artist + " - " + _mp3Info.Title;
        }

        public void Open()
        {
            mciSendString("open \"" + _path + "\" alias " + _alias, new StringBuilder(), 0, IntPtr.Zero);
        }

        public void Play()
        {

            mciSendString("play " + _alias, new StringBuilder(), 0, IntPtr.Zero);
            _position.Start();
        }

        public void Stop()
        {
            mciSendString("close " + _alias, new StringBuilder(), 0, IntPtr.Zero);
            mciSendString("open \"" + _path + "\" alias " + _alias, new StringBuilder(), 0, IntPtr.Zero);
            _position.Reset();
        }

        public void Pause()
        {
            mciSendString("pause " + _alias, new StringBuilder(), 0, IntPtr.Zero);
            _position.Stop();
        }

        public void Close()
        {
            mciSendString("close " + _alias, new StringBuilder(), 0, IntPtr.Zero);
            _position.Stop();
        }

        public void SetAudio(int volume)
        {
            mciSendString("setaudio " + _alias + " volume to " + volume.ToString(), new StringBuilder(), 0, IntPtr.Zero);
        }

        /// <summary>
        /// Décode les informations sur un mp3 (Id3 et informations d'encodage)
        /// </summary>
        private void DecodeMp3()
        {
            var reader = new BinaryReader(File.OpenRead(_path));
            if (Encoding.ASCII.GetString(reader.ReadBytes(3)) != "ID3")
            {
                throw new InvalidMp3Exception("ID3 Not found at beginning of file");
            }
            _mp3Info = V2Extractor.Extract(reader);

            reader.BaseStream.Seek(_mp3Info.Id3Size, SeekOrigin.Begin);

            //Extraction des propriétés du Mp3
            bool found = false;
            string bits, byte2;
            do
            {
                if (Convert.ToInt16(reader.ReadByte()) == 255 && Convert.ToInt16(reader.ReadByte()) > 223)
                {
                    double sizeMp3 = reader.BaseStream.Length - reader.BaseStream.Position;
                    found = true;
                    reader.BaseStream.Position -= 1;
                    bits = Convert.ToString(reader.ReadByte(), 2).PadLeft(8, '0');
                    if (bits[4] == '1')
                    {
                        _MPEG = 1;
                    }
                    else
                    {
                        _MPEG = 2;
                    }

                    // Process byte 2
                    byte2 = Convert.ToString(reader.ReadByte(), 2).PadLeft(8, '0');
                    _frequency = TrouverFrequence(byte2.Substring(4, 2));

                    // Process byte 3
                    bits = Convert.ToString(reader.ReadByte(), 2).PadLeft(8, '0');
                    _mono = bits.Substring(0, 2) == "11";
                    _padding = bits.Substring(6, 1) == "1";

                    // Keep track of previous stream position
                    long tampon = reader.BaseStream.Position;

                    int offsetvbr;
                    // Check if VBR or CBR
                    if (_mono)
                    {
                        if (_MPEG == 1)
                        {
                            reader.ReadBytes(17);
                            offsetvbr = 19;
                        }
                        else
                        {
                            reader.ReadBytes(9);
                            offsetvbr = 27;
                        }
                    }
                    else
                    {
                        if (_MPEG == 1)
                        {
                            reader.ReadBytes(32);
                            offsetvbr = 4;
                        }
                        else
                        {
                            reader.ReadBytes(17);
                            offsetvbr = 19;
                        }
                    }

                    _VBR = Convert.ToByte(reader.ReadByte()) == 88 &&
                            Convert.ToByte(reader.ReadByte()) == 105 &&
                            Convert.ToByte(reader.ReadByte()) == 110 &&
                            Convert.ToByte(reader.ReadByte()) == 103;

                    if (!_VBR)
                    {
                        _bitrate = TrouverBitrate(byte2.Substring(0, 4));
                    }
                }
            } while (found == false);
            reader.Close();
        }

        /// <summary>
        /// Cette méthode permet d'obtenir la valeur entière d'une chaîne de bits
        /// </summary>
        /// <param name="bits"></param>
        /// <returns></returns>
        private int TrouverValeur(string bits)
        {
            int valeur = 0;
            for (int i = bits.Length - 1; i >= 0; i--)
            {
                if (bits[i] == '1')
                {
                    valeur += (int)Math.Pow(2, bits.Length - 1 - i);
                }
            }
            return valeur;
        }
        private int TrouverBitrate(string bits)
        {
            switch (TrouverValeur(bits))
            {
                case 9:
                    return 128000;
                case 14:
                    return 320000;
                case 11:
                    return 192000;
                case 8:
                    return 112000;
                case 10:
                    return 160000;
                case 1:
                    return 32000;
                case 2:
                    return 40000;
                case 3:
                    return 48000;
                case 4:
                    return 56000;
                case 5:
                    return 64000;
                case 6:
                    return 80000;
                case 7:
                    return 96000;
                case 12:
                    return 224000;
                case 13:
                    return 256000;
                default:
                    return 0;
            }
        }

        private int TrouverFrequence(string bits)
        {
            switch (TrouverValeur(bits))
            {
                case 0:
                    return 44100;
                case 1:
                    return 48000;
                case 2:
                    return 32000;
                default:
                    return 0;
            }
        }
    }
}
