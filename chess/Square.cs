using System;
using System.Collections.Generic;
using System.Text;

namespace chess
{
    public class Square
    {
        /// <summary>
        /// Stores a count of 
        /// </summary>
        public Dictionary<Color, int> ThreatCount = new Dictionary<Color, int>
        {
            [Color.BLACK] = 0,
            [Color.WHITE] = 0
        };
    }
}
