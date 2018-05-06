using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Game
    {
        public Board GameBoard { get; set; }
        public IPlayer WhitePlayer { get; set; }
        public IPlayer BlackPlayer { get; set; }
        private IPlayer CurrentPlayer;
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
    }
}
