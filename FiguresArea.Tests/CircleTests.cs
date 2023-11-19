using Xunit.Sdk;

namespace FiguresArea.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Square_r6__return__113_09733552923255()
        {
            //Arrange
            int r = 6;
            double expected = 113.09733552923255;
            //Actions
            double result = FiguresOperations.Circle.Square(r);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}