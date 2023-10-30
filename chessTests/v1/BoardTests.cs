using Microsoft.VisualStudio.TestTools.UnitTesting;
using chess;
using System;
using System.Collections.Generic;
using System.Text;
using chess.v1.Pieces;
using System.Linq;

namespace chess.v1.Tests
{
    [TestClass()]
    public class BoardTests
    {
        [TestMethod()]
        public void BoardCreateTest()
        {
            string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR";
            Board board = new Board(fen);
            Assert.AreEqual(32, board.Pieces.Count);

            List<Piece> bishops = board.Pieces.Where(x => x.Type == PieceType.BISHOP).ToList();
            Assert.IsTrue(bishops.All(x => x.Location.Rank == 0 || x.Location.Rank == 7));
            Assert.IsTrue(bishops.All(x => x.Location.File == 2 || x.Location.File == 5));

        }
    }
}