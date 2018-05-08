using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class HumanPlayer : IPlayer
    {
        public string PieceSymbol { get; set; }
        public string PromptForColor()
        {
            Console.Write("Which color do you want to be? Black or White? [B][W]: ");
            string colorChoice = Console.ReadLine();

            if (colorChoice.ToUpper() != "B" && colorChoice.ToUpper() != "W")
            {
                Console.WriteLine("Please pick either B or W for a color choice.");
                Console.WriteLine();
                colorChoice = PromptForColor();
            }

            PieceSymbol = (colorChoice.ToUpper() == "W") ? "O" : "X";

            return colorChoice;
        }
        public Move GetMove(List<Move> validMoves, Board gameBoard)
        {
            return new Move();
        }
    }
}
