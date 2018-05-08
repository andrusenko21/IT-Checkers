﻿using Checkers;
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


        [TestMethod()]
        public void DoMoveTestForJumpUpdateDownRight()
        {
            IPlayer whitePlayer = new ComputerPlayer();
            IPlayer blackPlayer = new ComputerPlayer();
            Board gameBoard = TestHelper.CreateEmptyBoard();
            gameBoard[2][1] = "O";
            gameBoard[3][2] = "X";
            Game target = new Game(whitePlayer, blackPlayer, gameBoard);
            Move move = new Move() { From = new Tuple<int, int>(2, 1), To = new Tuple<int, int>(4, 3), IsJump = true };

            target.DoMove(move);

            Assert.IsTrue(target.GameBoard[3][2] == ".");
            Assert.IsTrue(target.GameBoard[2][1] == ".");
            Assert.IsTrue(target.GameBoard[4][3] == "O");
        }

        [TestMethod()]
        public void DoMoveTestForJumpUpdateDownLeft()
        {
            IPlayer whitePlayer = new ComputerPlayer();
            IPlayer blackPlayer = new ComputerPlayer();
            Board gameBoard = TestHelper.CreateEmptyBoard();
            gameBoard[2][3] = "O";
            gameBoard[3][2] = "X";
            Game target = new Game(whitePlayer, blackPlayer, gameBoard);
            Move move = new Move() { From = new Tuple<int, int>(2, 3), To = new Tuple<int, int>(4, 1), IsJump = true };

            target.DoMove(move);

            Assert.IsTrue(target.GameBoard[2][3] == ".");
            Assert.IsTrue(target.GameBoard[3][2] == ".");
            Assert.IsTrue(target.GameBoard[4][1] == "O");
        }

        [TestMethod()]
        public void DoMoveTestForJumpUpdateUpLeft()
        {
            IPlayer whitePlayer = new ComputerPlayer();
            IPlayer blackPlayer = new ComputerPlayer();

            Board gameBoard = TestHelper.CreateEmptyBoard();
            gameBoard[4][3] = "O";
            gameBoard[3][2] = "X";
            Game target = new Game(whitePlayer, blackPlayer, gameBoard);
            Move move = new Move() { From = new Tuple<int, int>(4, 3), To = new Tuple<int, int>(2, 1), IsJump = true };

            target.DoMove(move);

            Assert.IsTrue(target.GameBoard[3][2] == ".");
            Assert.IsTrue(target.GameBoard[2][1] == "O");
            Assert.IsTrue(target.GameBoard[4][3] == ".");
        }

        [TestMethod()]
        public void DoMoveTestForJumpUpdateUpRight()
        {
            IPlayer whitePlayer = new ComputerPlayer();
            IPlayer blackPlayer = new ComputerPlayer();

            Board gameBoard = TestHelper.CreateEmptyBoard();
            gameBoard[4][1] = "O";
            gameBoard[3][2] = "X";
            Game target = new Game(whitePlayer, blackPlayer, gameBoard);
            Move move = new Move() { From = new Tuple<int, int>(4, 1), To = new Tuple<int, int>(2, 3), IsJump = true };

            target.DoMove(move);

            Assert.IsTrue(target.GameBoard[3][2] == ".");
            Assert.IsTrue(target.GameBoard[2][3] == "O");
            Assert.IsTrue(target.GameBoard[4][1] == ".");
        }
    }
}