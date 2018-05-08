using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class GameManager
    {
        private Game game;
        public Game Game { get { return game; } }
        public GameManager()
        {
            IPlayer human = new HumanPlayer();
            IPlayer computer = new ComputerPlayer();

            string color = ((HumanPlayer)human).PromptForColor();
            color = color.ToUpper();

            IPlayer whitePlayer = (color == "B") ? computer : human;
            IPlayer blackPlayer = (color == "B") ? human : computer;

            Init(whitePlayer, blackPlayer);
        }
        public GameManager(IPlayer whitePlayer, IPlayer blackPlayer, Board board = null)
        {
            Init(whitePlayer, blackPlayer, board);
        }
        private void Init(IPlayer whitePlayer, IPlayer blackPlayer, Board board = null)
        {
            if (whitePlayer == null) whitePlayer = new ComputerPlayer();
            if (blackPlayer == null) blackPlayer = new ComputerPlayer();
            if (board == null) board = new Board();

            whitePlayer.PieceSymbol = "O";
            blackPlayer.PieceSymbol = "X";

            game = new Game(whitePlayer, blackPlayer, board);
        }
    }
}
