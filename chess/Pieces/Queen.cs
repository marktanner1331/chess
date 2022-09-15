using System;
using System.Collections.Generic;
using System.Text;

namespace chess.Pieces
{
    internal class Queen : Piece
    {
        public Queen(Color color, Location location, Board board) : base(color, location, PieceType.QUEEN, board)
        {

        }

        public override void Remap()
        {

        }
    }
}