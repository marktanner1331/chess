using chess.Pieces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace chess
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

        public abstract void Remap();

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
