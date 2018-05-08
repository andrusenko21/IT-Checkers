using Checkers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CheckersTests
{


    [TestClass()]
    public class GameManagerTest
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
        public void GameStopsForDrawTest()
        {
            IPlayer whitePlayer = new ComputerPlayer();
            IPlayer blackPlayer = new ComputerPlayer();
            Board board = TestHelper.CreateEmptyBoard();
            board[3][0] = "X";
            board[3][2] = "X";
            board[3][4] = "X";
            board[3][6] = "X";
            board[4][1] = "O";
            board[4][3] = "O";
            board[4][5] = "O";
            board[4][7] = "O";

            GameManager target = new GameManager(whitePlayer, blackPlayer, board);

            Assert.IsTrue(target.IsDraw);
        }

        [TestMethod()]
        public void GameStopsForWinTest()
        {
            IPlayer whitePlayer = new ComputerPlayer();
            IPlayer blackPlayer = new ComputerPlayer();
            Board board = TestHelper.CreateEmptyBoard();
            board[3][6] = "X";
            board[4][1] = "O";
            board[4][3] = "O";
            board[4][5] = "O";
            board[4][7] = "O";

            GameManager target = new GameManager(whitePlayer, blackPlayer, board);

            Assert.IsTrue(target.Winner == "White");
        }

        [TestMethod()]
        public void FullGame()
        {
            IPlayer whitePlayer = new ComputerPlayer();
            IPlayer blackPlayer = new ComputerPlayer();
            Board board = new Board();

            GameManager target = new GameManager(whitePlayer, blackPlayer, board);

            Assert.Inconclusive();
        }
    }
}
