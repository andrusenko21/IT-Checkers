using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkers
{
    interface IFormBoard
    {
        string getColorOnPosition(Tuple<int, int> coord);
        List<string> this[int x] { get; set; }
    }
}
