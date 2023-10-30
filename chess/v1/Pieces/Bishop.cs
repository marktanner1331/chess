using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chess.v1.Pieces
{
    public class Bishop : Piece
    {
        /// <summary>
        /// contains a list of possible squares we can move to
        /// not taking into account the king being in check
        /// </summary>
        private List<Square> PossibleMoves;

        public Bishop(Color color, Location location, Board board) : base(color, location, PieceType.BISHOP, board)
        {

        }

        public override IEnumerable<int> ListPossibleMoves()
        {
            return PossibleMoves.Select(x => x.Offset);
        }

        public override void Remap()
        {
            PossibleMoves = new List<Square>();

            int northEast = Math.Min(7 - Location.File, 7 - Location.Rank);
            base.ExplorePathForThreats(northEast, 9, PossibleMoves.Add);

            int southEast = Math.Min(7 - Location.File, Location.Rank);
            base.ExplorePathForThreats(southEast, -7, PossibleMoves.Add);

            int southWest = Math.Min(Location.File, Location.Rank);
            base.ExplorePathForThreats(southWest, -9, PossibleMoves.Add);

            int northWest = Math.Min(Location.File, 7 - Location.Rank);
            base.ExplorePathForThreats(northWest, 7, PossibleMoves.Add);
        }
    }
}