using System;
using System.Collections.Generic;
using System.Text;

namespace chess.Pieces
{
    internal class Pawn : Piece
    {
        public Pawn(Color color, Location location, Board board) : base(color, location, PieceType.PAWN, board)
        {
            
        }

        public override void Remap()
        {
            
        }
    }
}
