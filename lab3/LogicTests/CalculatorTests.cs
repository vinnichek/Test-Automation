using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Logic.Calculator;

namespace LogicTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_Positive_Input_Values()
        {
            double actual = Add(1, 2);
            double expected = 3;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Add_Positive_And_Negative_Input_Values()
        {
            double actual = Add(4, -3);
            double expected = 1;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Add_Negative_Input_Values()
        {
            double actual = Add(-5, -7);
            double expected = -12;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Add_Positive_And_Zero_Input_Values()
        {
            double actual = Add(5, 0);
            double expected = 5;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Substract_Positive_Input_Values()
        {
            double actual = Substract(8, 3);
            double expected = 5;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Substract_Negative_And_Positive_Input_Values()
        {
            double actual = Substract(5, -2);
            double expected = 7;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Substract_Negative_Input_Values()
        {
            double actual = Substract(-6, -7);
            double expected = 1;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Multiply_Number_And_Zero_Input_Values()
        {
            double actual = Multiply(-6, 0);
            double expected = 0;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Multiply_Positive_Input_Values()
        {
            double actual = Multiply(8, 3);
            double expected = 24;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Multiply_Negative_And_Positive_Input_Values()
        {
            double actual = Multiply(5, -2);
            double expected =  -10;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Multiply_Negative_Input_Values()
        {
            double actual = Multiply(-6, -7);
            double expected = 42;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Divide_Positive_Input_Values()
        {
            double actual = Divide(10, 2);
            double expected = 5;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Divvide_Negative_And_Positive_Input_Values()
        {
            double actual = Divide(-15, 3);
            double expected = -5;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Divide_Negative_Input_Values()
        {
            double actual = Divide(-10, -2);
            double expected = 5;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Divide_Zero_By_Number_Input_Values()
        {
            double actual = Multiply(0, -2);
            double expected = 0;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Divide_By_Zero_ThrowsInvalidOperationException()
        {
            double actual = Divide(5, 0);
        }
    }
}
