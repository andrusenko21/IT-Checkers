using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    interface IPlayer
    {
        string PieceSymbol { get; set; }
        Move GetMove(List<Move> validMoves);
    }
}
