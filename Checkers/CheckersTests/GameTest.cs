using Checkers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CheckersTests
{
    [TestClass()]
    public class GameTest
    {


        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        [TestMethod()]
        public void GetRemainingPiecesTest()
        {
            IPlayer whitePlayer = new ComputerPlayer();
            IPlayer blackPlayer = new ComputerPlayer();
            Board board = new Board();

            Game target = new Game(whitePlayer, blackPlayer, board);
            string color = "White";
            int expected = 12;
            int actual;
            actual = target.GetRemainingPieces(color);
            Assert.AreEqual(expected, actual);
        }

    }
}
