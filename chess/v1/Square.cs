using System;
using System.Collections.Generic;
using System.Text;

namespace chess.v1
{
    public class Square
    {
        /// <summary>
        /// Stores a count of how many pieces are protecting this square per player
        /// </summary>
        public Dictionary<Color, int> ThreatCount = new Dictionary<Color, int>
        {
            [Color.BLACK] = 0,
            [Color.WHITE] = 0
        };

        public readonly int Offset;

        public Square(int offset)
        {
            Offset = offset;
        }
    }
}
