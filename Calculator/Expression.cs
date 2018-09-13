using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    // Class used to contain an operation between two numbers
    public class Expression
    {
        private readonly int number1;

        private readonly int number2;

        // Operation used on number1 and number2
        private readonly Func<int, int, int> operation;

        public Expression(int number1, int number2, Func<int, int, int> operation)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.operation = operation;
        }

        // Evaluate the expression with its content
        public int Evaluate()
        {
            return operation(number1, number2);
        }
    }
}
