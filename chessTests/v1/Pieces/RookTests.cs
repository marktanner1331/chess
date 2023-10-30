using Microsoft.VisualStudio.TestTools.UnitTesting;
using chess.v1.Pieces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace chess.v1.Pieces.Tests
{
    [TestClass()]
    public class RookTests
    {
        [TestMethod()]
        public void RemapTest()
        {
            string fen = "4k3/8/8/8/8/3R4/8/4K3 w - - 0 1";
            Board board = new Board(fen);
            Rook rook = board.FirstPieceOfType<Rook>(PieceType.ROOK);

            Assert.AreEqual(14, rook.ListPossibleMoves().Count());
        }
    }
}