using System;
using System.IO;

namespace Calculator
{
    public class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                ICalculatorInputReader reader;
                if (args.Length == 0)
                {
                    throw new Exception("Missing parameter, use interactive or specify a filename");
                }
                if (args[0] == "interactive")
                {
                    reader = new InteractiveCalculatorInputReader();
                }
                else
                {
                    reader = new FileCalculatorInputReader(args[0]);
                }
                var expression = Parser.Parse(reader.GetLines());
                Console.WriteLine($"Result{expression.Evaluate()}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }
    }
}

