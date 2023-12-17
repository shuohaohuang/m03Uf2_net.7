using FigureArea;

namespace FigureAreaTest
{
    [TestClass]
    public class FigureAreaTest
    {
        [TestMethod]
        public void CalculateFigureArea_InputFourAndFour_ReturnSixteen()
        {
            //Arrange
            double width = 4;
            double height = 4;

            //Act
            double result = FigureArea.FigureArea.CalculateFigureArea(width, height);
            //Assert
            Assert.AreEqual(16,result);
        }
        [TestMethod]
        public void CalculateFigureArea_InputMinusFourAndFour_ReturnSixteen()
        {
            //Arrange
            double width = -4;
            double height = 4;

            //Act
            double result = FigureArea.FigureArea.CalculateFigureArea(width, height);
            //Assert
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void CalculateFigureArea_inputThreePointFour_ReturnX()
        {
            //Arrange
            double radius = 3.4;

            //Act
            double result = FigureArea.FigureArea.CalculateFigureArea(radius);
            //Assert
            Assert.AreEqual(36.317, result);
        }
        [TestMethod]
        public void CalculateFigureArea_inputMinusThreePointFour_ReturnX()
        {
            //Arrange
            double radius = -3.4;

            //Act
            double result = FigureArea.FigureArea.CalculateFigureArea(radius);
            //Assert
            Assert.AreEqual(36.317, result);
        }
        [TestMethod]
        public void CalculateFigureArea_inputFiveFive_ReturnX()
        {
            //Arrange
            int side = 5;
            double width = 5;

            //Act
            double result = FigureArea.FigureArea.CalculateFigureArea(side,width);
            //Assert
            Assert.AreEqual(43.012, result);
        }

        [TestMethod]
        public void CalculateFigureArea_inputFiveAndMinusFive_ReturnX()
        {
            //Arrange
            int side = 5;
            double width = -5;

            //Act
            double result = FigureArea.FigureArea.CalculateFigureArea(side, width);
            //Assert
            Assert.AreEqual(43.012, result);
        }
        [TestMethod]
        public void CalculateFigureArea_inputNineAndMinusFive_ReturnX()
        {
            //Arrange
            int side = 9;
            double width = -5;

            //Act
            double result = FigureArea.FigureArea.CalculateFigureArea(side, width);
            //Assert
            Assert.AreEqual(154.546, result);
        }
        [TestMethod]
        public void CalculateFigureArea_inputHundredAndMinusFive_ReturnX()
        {
            //Arrange
            int side = 100;
            double width = -5;

            //Act
            double result = FigureArea.FigureArea.CalculateFigureArea(side, width);
            //Assert
            Assert.AreEqual(19887.822, result);
        }
    }
}