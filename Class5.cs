using System;

namespace Assignment_02
{
	static class Class5
	{
	 public	static void method()
		{
            int number;

            // Input validation
            while (true)
            {
                Console.Write("Enter a number to print its multiplication table (up to 10): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            Console.WriteLine($"\nMultiplication Table for {number}:");

            // Print multiplication table from 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
    }
	}

}
