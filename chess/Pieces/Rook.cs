using System;
using System.Collections.Generic;
using System.Text;

namespace chess.Pieces
{
    internal class Rook : Piece
    {
        public Rook(Color color, Location location, Board board) : base(color, location, PieceType.ROOK, board)
        {

        }

        public override void Remap()
        {

        }
    }
}