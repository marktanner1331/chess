using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chess.v1.Pieces
{
    internal class Knight : Piece
    {
        /// <summary>
        /// contains a list of possible squares we can move to
        /// not taking into account the king being in check
        /// </summary>
        private List<Square> PossibleMoves;

        public Knight(Color color, Location location, Board board) : base(color, location, PieceType.KNIGHT, board)
        {

        }

        public override IEnumerable<int> ListPossibleMoves()
        {
            return PossibleMoves.Select(x => x.Offset);
        }

        public override void Remap()
        {

        }
    }
}