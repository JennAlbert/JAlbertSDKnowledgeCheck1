using KnowledgeCheck1_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Hello. Please enter + for addition, - for subtraction, * for multiplication, / for division, exit to Close");

var userInput = Console.ReadLine();

while (true)

{

    switch (userInput)
    {

        case "+":
            Console.WriteLine("Enter 2 integers to add");

            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            if (int.TryParse(input1, out int addNumOne) && int.TryParse(input2, out int addNumTwo))
            {
                Console.WriteLine($"{input1} + {input2} = " + Calculator.Add(addNumOne, addNumTwo));
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an integer.");
            }
            break;

        case "-":
            Console.WriteLine("Enter 2 integers to subtract");

            var subtractOne = Console.ReadLine();
            var subtractTwo = Console.ReadLine();

            if (int.TryParse(subtractOne, out int subNumOne) && int.TryParse(subtractTwo, out int subNumTwo))
            {
                Console.WriteLine($"{subtractOne} - {subtractTwo} = " + Calculator.Subtract(subNumOne, subNumTwo));

            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an integer.");
            }
            break;

        case "*":

            Console.WriteLine("Enter 2 integers to multiply");

            var multiplyOne = Console.ReadLine();
            var multiplyTwo = Console.ReadLine();

            if (int.TryParse(multiplyOne, out int multNumOne) && int.TryParse(multiplyTwo, out int multNumTwo))

            {
                Console.WriteLine($"{multiplyOne} * {multiplyTwo} = " + Calculator.Multiply(multNumOne, multNumTwo));
            }

            else
            {
                Console.WriteLine("One or more of the numbers is not an integer.");
            }
            break;

        case "/":

            Console.WriteLine("Enter 2 integers to divide");

            var divideOne = Console.ReadLine();
            var divideTwo = Console.ReadLine();

            if (double.TryParse(divideOne, out double divNumOne) && double.TryParse(divideTwo, out double divNumTwo))
            {
                Console.WriteLine($"{divideOne} / {divideTwo} = " + Calculator.Divide(divNumOne, divNumTwo));
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an integer.");
            }
            break;

        case "exit":

            {
                Console.WriteLine("Goodbye. Closing program.");

                Environment.Exit(0);
            }

            break;

        default:
            Console.WriteLine("Unknown input");
            break;
    }
}
