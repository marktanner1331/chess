using System;
using System.Collections.Generic;
using System.Text;

namespace chess
{
    public class Location
    {
        public int Rank;
        public int File;

        /// <summary>
        /// offset is stored as 6 bits
        /// the first 3 are the File, the last 3 are the Rank
        /// </summary>
        /// <param name="offset"></param>
        public Location(int offset)
        {
            File = offset >> 3;
            Rank = offset % 8;
        }

        public int ToOffset()
        {
            return (File << 3) + Rank;
        }
    }
}
