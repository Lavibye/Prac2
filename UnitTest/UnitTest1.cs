using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Prac2;
using System.Threading.Tasks;

namespace Prac2
{
    [TestClass]
    public class TaskTests
    {
        [TestMethod]
        public void TestCalculateSumOrAverage_AllOdd()
        {
            // Arrange
            int a = 3, b = 5, c = 7;

            // Act
            double result = Prac3.CalculateSumOrAverage(a, b, c);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestCalculateSumOrAverage_NotAllOdd()
        {
            // Arrange
            int a = 3, b = 4, c = 7;

            // Act
            double result = Prac3.CalculateSumOrAverage(a, b, c);

            // Assert
            Assert.AreEqual((a + b + c) / 3.0, result);
        }

        [TestMethod]
        public void TestCountSpecialNumbers()
        {
            // Arrange
            int start = 1, end = 100;

            // Act
            int count = Prac3.CountSpecialNumbers(start, end);

            // Assert
            Assert.AreEqual(3, count); // 29, 59, 89 - числа, які відповідають умові
        }
    }
}


