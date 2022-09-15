using System;
using System.Collections.Generic;
using System.Text;

namespace chess.Pieces
{
    internal class Knight : Piece
    {
        public Knight(Color color, Location location, Board board) : base(color, location, PieceType.KNIGHT, board)
        {

        }

        public override void Remap()
        {

        }
    }
}