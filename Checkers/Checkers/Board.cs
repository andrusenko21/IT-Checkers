using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Board : List<List<string>>
    {
        public Board()
        {
            for (int i = 0; i < 8; i++)
            {
                if (i < 3) Add(BuildInitialRow("X", i));
                if (i > 2 && i < 5) Add(BuildInitialRow(".", i));
                if (i > 4) Add(BuildInitialRow("O", i));
            }
        }
        private List<string> BuildInitialRow(string type, int rowNum)
        {
            string firstType = ".", secondType = ".";
            if (rowNum % 2 == 0)
            {
                firstType = ".";
                secondType = type;
            }
            else
            {
                firstType = type;
                secondType = ".";
            }

            return new List<string>() { firstType, secondType, firstType, secondType, firstType, secondType, firstType, secondType };
        }
    }
}
