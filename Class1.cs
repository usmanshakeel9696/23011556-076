using System;

namespace Assignment_02
{
  static class Class1
    {
  public static void method()
        {
            // Even or odd checker
            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"{number} is even");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is odd");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }}
    }
}

