using System;
using System.Collections.Generic;
using System.Text;

namespace chess.v1.Pieces
{
    internal class Pawn : Piece
    {
        public Pawn(Color color, Location location, Board board) : base(color, location, PieceType.PAWN, board)
        {
            
        }

        public override IEnumerable<int> ListPossibleMoves()
        {
            throw new NotImplementedException();
        }

        public override void Remap()
        {
            
        }
    }
}
