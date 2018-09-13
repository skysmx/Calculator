Calculator v1.1
===============

This Calculator accepts 4 different operations and it improve the code quality, separating
the different parts of the old Calculator application.

It also defines a project CalculatorTests for testing the different main classes, using MSTest V2.

The program does read a list of strings, containing a number or an operator.
It is made for executing a single operation between two numbers.
It also accepts only two numbers (and use the default sum operation) and it returns the string
"Return" with the actual result without a space between both for retrocompatibility. It also read the file line by line
like before, accepting also only two numbers.

The program still has the interactive mode or the file reader mode.

The program is composed of those files:
- Program.cs: the entry point of the application. It accepts a single string argument.
- Parser.cs: it contains the logic to parse and build the expression between the inputs
- Expression.cs: it contains a wrapper for the two numbers and the operation
- ICalculatorInputReader.cs: inteface to define a reader for the input, returning a list of strings
- FileCalculatorInputReader.cs: read data from a local file
- InteractiveCalculatorInputReader.cs: read data from the console (interactive mode)

The tests are inside the project CalculatorTests

Executing
---
Just open the solution Calculator and execute all the unit tests.

Future improvements
---
- Generate a temporary file instead of using an existing one for the unit test.
- Choose an improved number store, like System.Numerics.BigInteger.
- It can be developed a better tokenizer, to build an AST tree for multiple operations.
- Extend the operations, like power or modulo.
- Extract the main parsing/evaluating code as a library.

Stefano Mondini
