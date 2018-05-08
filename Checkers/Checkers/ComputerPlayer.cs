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
            return new Move();
        }
    }
}
