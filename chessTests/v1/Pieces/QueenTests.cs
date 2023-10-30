using Microsoft.VisualStudio.TestTools.UnitTesting;
using chess.v1.Pieces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace chess.v1.Pieces.Tests
{
    [TestClass()]
    public class QueenTests
    {
        [TestMethod()]
        public void RemapTest()
        {
            string fen = "4k3/8/8/8/8/3Q4/8/4K3 w - - 0 1";
            Board board = new Board(fen);
            Queen queen = board.FirstPieceOfType<Queen>(PieceType.QUEEN);

            Assert.AreEqual(25, queen.ListPossibleMoves().Count());
        }
    }
}