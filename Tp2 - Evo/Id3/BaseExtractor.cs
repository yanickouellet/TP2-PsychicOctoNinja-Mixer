using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DJ.Id3
{
    public abstract class BaseExtractor
    {
        public abstract Id3Tag Extract();

        protected int DecodeSynchsafe32(byte[] synchInt)
        {
            int retVal = 0;

            retVal += ((int)synchInt[0]) << 21;
            retVal += ((int)synchInt[1]) << 14;
            retVal += ((int)synchInt[2]) << 7;
            retVal += (int)synchInt[3];

            return retVal;
        }

        protected string GetFrameData(BinaryReader id3Frame)
        {
            int frameSize = DecodeSynchsafe32(id3Frame.ReadBytes(4));
            id3Frame.BaseStream.Seek(3, SeekOrigin.Current);

            return new String(id3Frame.ReadChars(frameSize - 1));
        }

    }

}
