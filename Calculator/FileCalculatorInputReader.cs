using System;
using System.Collections.Generic;
using System.IO;

namespace Calculator
{
    // Read content from a file
    public class FileCalculatorInputReader : ICalculatorInputReader
    {
        private readonly string filename;

        public FileCalculatorInputReader(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                throw new ArgumentException("File path is set to an empty value.");
            }
            this.filename = filename;
        }

        public List<string> GetLines()
        {
            var lines = new List<string>();
            foreach (var line in File.ReadLines(filename))
            {
                lines.Add(line.Trim());
            }
            return lines;
        }
    }
}
