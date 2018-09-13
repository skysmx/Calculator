using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Calculator.Tests
{
    [TestClass()]
    public class ParserTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
            "Argument cannot be empty or null.")]
        public void ParseWithNullArgument()
        {
            Parser.Parse(null);
            Assert.Fail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
            "Argument cannot be empty or null.")]
        public void ParseWithEmptyString()
        {
            var list = new List<string>();
            Parser.Parse(list);
            Assert.Fail();
        }

        [TestMethod()]
        public void ParseUsingDefaultOperationWithZeros()
        {
            var list = new List<string> { "0", "0" };
            var expectedResult = 0;
            Assert.AreEqual(expectedResult, Parser.Parse(list).Evaluate());
        }

        [TestMethod()]
        public void ParseUsingDefaultOperation()
        {
            var list = new List<string> { "1", "5" };
            var expectedResult = 6;
            Assert.AreEqual(expectedResult, Parser.Parse(list).Evaluate());
        }

        [TestMethod()]
        public void ParseUsingSumOperation()
        {
            var list = new List<string> { "1", "5", "+" };
            var expectedResult = 6;
            Assert.AreEqual(expectedResult, Parser.Parse(list).Evaluate());
        }

        [TestMethod()]
        public void ParseUsingSubtractOperation()
        {
            var list = new List<string> { "1", "5", "-" };
            var expectedResult = -4;
            Assert.AreEqual(expectedResult, Parser.Parse(list).Evaluate());
        }

        [TestMethod()]
        public void ParseUsingMultiplyOperation()
        {
            var list = new List<string> { "1", "5", "*" };
            var expectedResult = 5;
            Assert.AreEqual(expectedResult, Parser.Parse(list).Evaluate());
        }

        [TestMethod()]
        public void ParseUsingDivisionOperation()
        {
            var list = new List<string> { "15", "5", "/" };
            var expectedResult = 3;
            Assert.AreEqual(expectedResult, Parser.Parse(list).Evaluate());
        }

        [TestMethod()]
        public void ParseUsingDivisionOperationWithZeros()
        {
            var list = new List<string> { "0", "0", "/" };
            Assert.ThrowsException<DivideByZeroException>(() => Parser.Parse(list).Evaluate());
        }
    }
}