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
    }
}