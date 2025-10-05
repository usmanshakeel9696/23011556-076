using System;

namespace Assigment_02
{
     public class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator\n");

            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.Write("Enter your choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    case "+":
                        Console.WriteLine($"\nResult: {num1} + {num2} = {num1 + num2}");
                        break;

                    case "2":
                    case "-":
                        Console.WriteLine($"\nResult: {num1} - {num2} = {num1 - num2}");
                        break;

                    case "3":
                    case "*":
                        Console.WriteLine($"\nResult: {num1} * {num2} = {num1 * num2}");
                        break;

                    case "4":
                    case "/":
                        if (num2 != 0)
                        {
                            Console.WriteLine($"\nResult: {num1} / {num2} = {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("\nError: Cannot divide by zero.");
                        }
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice. Please select 1-4 or use symbols (+, -, *, /).");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter valid numbers.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
