using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace Calculator.Tests
{
    [TestClass()]
    public class FileCalculatorInputReaderTests
    {
        [TestMethod()]
        public void ReadFileInputWithExistingData()
        {
            // TODO It expect an input.txt file with 10 and 12 as input
            var reader = new FileCalculatorInputReader(@"../../input.txt");
            var expectedLines = new List<string> { "10", "12" };
            var fileLines = reader.GetLines();
            CollectionAssert.AreEqual(expectedLines, fileLines);
        }

        [TestMethod()]
        public void ReadFileInputWithInvalidFilename()
        {
            Assert.ThrowsException<FileNotFoundException>(() => new FileCalculatorInputReader("invalidfile").GetLines());
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
            "File path is set to an empty value.")]
        public void ReadFileInputWithEmptyFilename()
        {
            var reader = new FileCalculatorInputReader("");
            Assert.Fail();
        }
    }
}