using System.Collections.Generic;

namespace Calculator
{
    // Input Reader is used to return a list of string inputs
    public interface ICalculatorInputReader
    {
        List<string> GetLines();
    }
}
