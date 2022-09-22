using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    [TestClass]
    public class AreaCalculatorTests
    {
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Exception was not thrown")]
        [TestMethod]
        public void Circle_RadiusMinus1_Exception()
        {
            double radius = -1.0;
            AreaCalculator.Circle(radius);
        }

        [TestMethod]
        public void Circle_Radius2_12Dot56Returned()
        {
            //Arrange
            double radius = 2.0;
            double expected = 12.56;
            double delta = 0.01;

            //Act
            double actual = AreaCalculator.Circle(radius);

            //Assert
            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void Triangle_4And3_6Returned()
        {
            //Arrange
            double side1 = 4.0;
            double side2 = 3.0;
            double expected = 6.0;

            //Act
            double actual = AreaCalculator.Triangle(side1, side2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_6And5And5_12Returned()
        {
            //Arrange
            double side1 = 6.0, side2 = 5.0, side3 = 5.0;
            double expected = 12.0;

            //Act
            double actual = AreaCalculator.Triangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException), "Exception was not thrown")]
        [TestMethod]
        public void Triangle_0And5_Exception()
        {
            double side1 = 0, side2 = 5.0;
            AreaCalculator.Triangle(side1, side2);
        }

        [ExpectedException(typeof(ArgumentException), "Exception was not thrown")]
        [TestMethod]
        public void Triangle_2And2And5_Exception()
        {
            double side1 = 2.0, side2 = 2.0, side3 = 5.0;
            AreaCalculator.Triangle(side1, side2, side3);
        }

        [TestMethod]
        public void IsTriangleRight_3And4And5()
        {
            //Arrange
            double side1 = 3.0, side2 = 4.0, side3 = 5.0;
            bool expected = true;

            //Act
            bool actual = AreaCalculator.IsTriangleRight(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_Radius1_3Dot14Returned()
        {
            //Arrange
            double radius = 1;
            double expected = 3.14;
            double delta = 0.01;

            //Act
            double actual = AreaCalculator.Area(radius);

            //Assert
            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void Area_Catheti30And40_600Expected()
        {
            //Arrange
            double cathetus1 = 30.0, cathetus2 = 40.0;
            double expected = 600.0;

            //Act
            double actual = AreaCalculator.Area(cathetus1, cathetus2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_TriangleSides3And4And5_6Returned()
        {
            //Arrange
            double side1 = 3.0, side2 = 4.0, side3 = 5.0;
            double expected = 6.0;

            //Act
            double actual = AreaCalculator.Area(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
