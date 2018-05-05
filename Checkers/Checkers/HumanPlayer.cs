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
        public Move GetMove(List<Move> validMoves)
        {
            return new Move();
        }
    }
}
