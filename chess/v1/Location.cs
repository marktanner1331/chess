using System;
using System.Collections.Generic;
using System.Text;

namespace chess.v1
{
    public class Location
    {
        /// <summary>
        /// stored as 0 based integers i.e. between 0-7
        /// </summary>
        public int Rank;
        public int File;

        /// <summary>
        /// offset is stored as 6 bits
        /// the first 3 are the Rank, the last 3 are the File
        /// </summary>
        public Location(int offset)
        {
            Rank = offset >> 3;
            File = offset % 8;
        }

        public int ToOffset()
        {
            return (Rank << 3) + File;
        }
    }
}
