using System;
using System.Collections.Generic;
using System.Text;

namespace chess.Pieces
{
    internal class King : Piece
    {
        public King(Color color, Location location, Board board) : base(color, location, PieceType.KING, board)
        {

        }

        public override void Remap()
        {

        }
    }
}