using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea.Tests
{
    [TestClass]
    public class RhombTests
    {
        [TestMethod]
        public void Square__d1_6__d2_6__return_18()
        {
            //Arrange
            double d1 = 6, d2 = 6, expected = 18;
            //Actions
            double result = FiguresOperations.Rhomb.Square(d1, d2);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
