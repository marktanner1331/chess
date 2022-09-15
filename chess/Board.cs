using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace chess
{
    public class Board
    {
        public List<Piece> Pieces = new List<Piece>();
        public Piece[] OffsetToPiece = new Piece[64];
        public Square[] OffsetToSquare = new Square[64];

        public Board(string fen)
        {
            int square = 0;
            string positions = fen.Split(' ')[0];

            foreach(char pos in positions)
            {
                if(pos == '/')
                {
                    continue;
                }
                else if(char.IsDigit(pos))
                {
                    square += int.Parse(pos.ToString());
                }
                else
                {
                    Color color = (char.IsUpper(pos)) ? Color.WHITE : Color.BLACK;
                    PieceType type;
                    switch(char.ToLower(pos))
                    {
                        case 'p':
                            type = PieceType.PAWN;
                            break;
                        case 'r':
                            type = PieceType.ROOK;
                            break;
                        case 'n':
                            type = PieceType.KNIGHT;
                            break;
                        case 'b':
                            type = PieceType.BISHOP;
                            break;
                        case 'q':
                            type = PieceType.QUEEN;
                            break;
                        case 'k':
                            type = PieceType.KING;
                            break;
                        default:
                            throw new Exception();
                    }

                    Location location = new Location(square);
                    Piece piece = Piece.Create(color, type, location, this);
                    Pieces.Add(piece);

                    square++;
                }
            }
        }

        /// <summary>
        /// Rebuilds all the maps
        /// </summary>
        public void RemapPieces()
        {
            foreach(Piece piece in this.Pieces)
            {
                piece.Remap();
            }
        }
    }
}
