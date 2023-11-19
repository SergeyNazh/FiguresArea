using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Square__a_4__b_10__c_10_77032961426901__return_20()
        {
            //Arrange
            double a = 4, b = 10, c = 10.77032961426901, expected = 20;
            //Actions
            double result = FiguresOperations.Triangle.Square(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void IsRectangular__a_3__b_4__c_5__return_true()
        {
            //Arrange
            double a = 3, b = 4, c = 5;
            bool expected = true;
            //Actions
            bool result = FiguresOperations.Triangle.IsRectangular(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
