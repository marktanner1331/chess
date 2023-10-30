using chess.v1.Pieces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace chess.v1
{
    public abstract class Piece
    {
        public Color Color;
        public Location Location;
        public PieceType Type;
        public Board Board;

        protected Piece(Color color, Location location, PieceType type, Board board)
        {
            Color = color;
            Location = location;
            Type = type;
            Board = board;
            Board.OffsetToPiece[location.ToOffset()] = this;
        }

        /// <summary>
        /// returns a list of squares (as offsets) that the piece can theoretically move to
        /// not taking into account the king being in check
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<int> ListPossibleMoves();

        public abstract void Remap();

        protected void ExplorePathForThreats(int pathLength, int delta, Action<Square> moveFound)
        {
            int offset = this.Location.ToOffset();
            for (int i = 0; i < pathLength; i++)
            {
                offset += delta;
                Square square = Board.OffsetToSquare[offset];

                square.ThreatCount[this.Color]++;

                if (Board.OffsetToPiece[offset] == null)
                {
                    //if the square is empty we can move to it and keep moving along the path
                    moveFound(square);
                }
                else
                {
                    //if it contains an enemy piece then we can take it
                    if (Board.OffsetToPiece[offset].Color != this.Color)
                    {
                        moveFound(square);
                    }

                    //but then we have to stop exploring the path
                    break;
                }
            }
        }

        public static Piece Create(Color color, PieceType pieceType, Location location, Board board)
        {
            switch(pieceType)
            {
                case PieceType.PAWN:
                    return new Pawn(color, location, board);
                case PieceType.ROOK:
                    return new Rook(color, location, board);
                case PieceType.KNIGHT:
                    return new Knight(color, location, board);
                case PieceType.BISHOP:
                    return new Bishop(color, location, board);
                case PieceType.QUEEN:
                    return new Queen(color, location, board);
                case PieceType.KING:
                    return new King(color, location, board);
                default:
                    throw new Exception();
            }
        }
    }
}
