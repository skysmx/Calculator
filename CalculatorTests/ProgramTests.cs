using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainWithoutArguments()
        {
            var args = new string[] { "" };
            var exitCode = Program.Main(args);
            Assert.AreEqual(-1, exitCode);
        }

        [TestMethod()]
        public void MainWithArguments()
        {
            var args = new string[] { @"../../input.txt" };
            var exitCode = Program.Main(args);
            Assert.AreEqual(0, exitCode);
        }
    }
}