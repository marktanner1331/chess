using Microsoft.VisualStudio.TestTools.UnitTesting;
using chess;
using System;
using System.Collections.Generic;
using System.Text;

namespace chess.Tests
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
        }
    }
}