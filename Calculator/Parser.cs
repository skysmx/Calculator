using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    // This class is used to parse the different inputs to obtain an Expression
    public class Parser
    {
        // Default operation like the original version of this application
        private const string DEFAULT_OPERATION = "+";

        // Default set of operations
        private static readonly Dictionary<string, Func<int, int, int>> operations = new Dictionary<string, Func<int, int, int>>
        {
            { "+", (x, y) => x + y },
            { "-", (x, y) => x - y },
            { "*", (x, y) => x * y },
            { "/", (x, y) => x / y }
        };

        // Parse a list of string inputs in an Expression
        public static Expression Parse(List<string> lines)
        {
            if ((lines is null) || (lines.Count == 0))
            {
                throw new ArgumentException($"Argument cannot be empty or null.");
            }
            int number1;
            int number2;
            var index = 0;
            // Scan each value, starting with first number
            (number1, index) = Scan(lines, index);
            // Find second value starting from last index
            (number2, index) = Scan(lines, index);
            // And now find the operator, if not just use the default one
            foreach (var line in lines)
            {
                if (operations.TryGetValue(line, out Func<int, int, int> operation))
                {
                    return new Expression(number1, number2, operation);
                }
            }
            return new Expression(number1, number2, operations[DEFAULT_OPERATION]);
        }

        // Scan from a valid integer number, starting from a specific index
        private static (int Number, int Index) Scan(List<string> lines, int index = 0)
        {
            for (var i = index; i < lines.Count; i++)
            {
                if (int.TryParse(lines.ElementAt(i), out var number))
                {
                    return (number, i+1);
                }
            }
            throw new Exception($"Cannot find an integer by the specified index {index}.");
        }
    }
}
