using System;
using System.Collections.Generic;
using System.Text;

namespace chess.v1.Pieces
{
    internal class King : Piece
    {
        public King(Color color, Location location, Board board) : base(color, location, PieceType.KING, board)
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