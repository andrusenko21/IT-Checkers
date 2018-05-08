using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class ComputerPlayer : IPlayer
    {
        public string PieceSymbol { get; set; }
        public Move GetMove(List<Move> validMoves, Board gameBoard)
        {
            var validJump = validMoves.Select(a => a).Where(b => b.IsJump && gameBoard[b.From.Item1][b.From.Item2] == PieceSymbol).FirstOrDefault();
            if (validJump != null) return validJump;

            return null;
        }
    }
}
