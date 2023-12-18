using System.Numerics;
using NaturalNums;

namespace Ex1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateNatural_GretterThanZero_True()
        {
            //Arrange
            int num = 1;
            //Act
            bool result = NaturalNum.ValidateNatural(num);
            //Assert
            Assert.IsTrue(result);
            
        }
        [TestMethod]
        public void ValidateNatural_Zero_False()
        {
            //Arrange
            int num = 0;
            //Act
            bool result = NaturalNum.ValidateNatural(num);
            //Assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void ValidateNatural_SmollerThanZero_False()
        {
            //Arrange
            int num = -1;
            //Act
            bool result = NaturalNum.ValidateNatural(num);
            //Assert
            Assert.IsFalse(result);

        }
    }
}