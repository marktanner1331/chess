using System;
using System.Collections.Generic;
using System.Text;

namespace chess.Pieces
{
    internal class Bishop : Piece
    {
        public Bishop(Color color, Location location, Board board) : base(color, location, PieceType.BISHOP, board)
        {

        }

        public override void Remap()
        {

        }
    }
}