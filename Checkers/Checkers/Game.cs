﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Checkers
{
    class Game
    {
        public Board GameBoard { get; set; }
        public IPlayer WhitePlayer { get; set; }
        public IPlayer BlackPlayer { get; set; }
        private IPlayer CurrentPlayer;
        public string PieceSymbol
        {
            get
            {
                return (CurrentPlayer.Equals(WhitePlayer)) ? "O" : "X";
            }
        }
        public Game(IPlayer whitePlayer, IPlayer blackPlayer, Board gameBoard)
        {
            if (whitePlayer == null || blackPlayer == null || gameBoard == null) throw new ArgumentException("Null arguments passed to Game constructor.");

            Init(whitePlayer, blackPlayer, gameBoard);
        }
        private void Init(IPlayer whitePlayer, IPlayer blackPlayer, Board gameBoard)
        {
            WhitePlayer = whitePlayer;
            BlackPlayer = blackPlayer;
              
            GameBoard = gameBoard;

            CurrentPlayer = whitePlayer;
        }
        public void DoMove(Move move)
        {
            UpdateBoard(move);

            if (CurrentPlayer.GetType() == typeof(ComputerPlayer))
            {
                Console.WriteLine("Computer moved from [" + move.From.Item1 + "," + move.From.Item2 + "] to [" + move.To.Item1 + "," + move.To.Item2 + "]");
                Console.WriteLine();
            }


            CurrentPlayer = (CurrentPlayer.Equals(WhitePlayer)) ? BlackPlayer : WhitePlayer;
        }

        private void UpdateBoard(Move move)
        {
            int rowFrom = move.From.Item1;
            int colFrom = move.From.Item2;
            int rowTo = move.To.Item1;
            int colTo = move.To.Item2;

            GameBoard[rowFrom][colFrom] = ".";
            GameBoard[rowTo][colTo] = PieceSymbol;
            if (move.IsJump)
            {
                var jumpedLocation = GetJumpedPieceCoordinates(rowFrom, colFrom, rowTo, colTo);
                GameBoard[jumpedLocation.Item1][jumpedLocation.Item2] = ".";
            }
        }
        private Tuple<int, int> GetJumpedPieceCoordinates(int fromRow, int fromCol, int toRow, int toCol)
        {
            int rowOfJumpedPiece = fromRow + ((fromRow > toRow) ? -1 : 1);
            int colOfJumpedPiece = fromCol + ((fromCol > toCol) ? -1 : 1);

            return new Tuple<int, int>(rowOfJumpedPiece, colOfJumpedPiece);
        }
    }
}
