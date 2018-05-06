using Checkers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CheckersTests
{
    [TestClass()]
    public class BoardTest
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod()]
        public void BoardConstructorTest()
        {
            Board target = new Board();
            string actual = target.ToString();
            string expected = "  0 1 2 3 4 5 6 7" + Environment.NewLine +
                            "0 . X . X . X . X" + Environment.NewLine +
                            "1 X . X . X . X ." + Environment.NewLine +
                            "2 . X . X . X . X" + Environment.NewLine +
                            "3 . . . . . . . ." + Environment.NewLine +
                            "4 . . . . . . . ." + Environment.NewLine +
                            "5 O . O . O . O ." + Environment.NewLine +
                            "6 . O . O . O . O" + Environment.NewLine +
                            "7 O . O . O . O ." + Environment.NewLine;

            Assert.AreEqual(expected, actual);
        }
    }
}
