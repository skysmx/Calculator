using System;
using System.Collections.Generic;

namespace Calculator
{
    // Read text from terminal (interactive)
    public class InteractiveCalculatorInputReader : ICalculatorInputReader
    {
        public List<string> GetLines()
        {
            var lines = new List<string>();
            Console.WriteLine("First argument: ");
            lines.Add(Console.ReadLine().Trim());
            Console.WriteLine("Operator [+, -, *, /] (optional, empty uses default +): ");
            lines.Add(Console.ReadLine().Trim());
            Console.WriteLine("Second Argument: ");
            lines.Add(Console.ReadLine().Trim());
            return lines;
        }
    }
}
