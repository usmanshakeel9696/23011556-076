using System;

namespace Assignment_02
{
	public class Class6
	{
		public Class6()
		{
            int number;

            // Get a valid non-negative integer 
            while (true)
            {
                Console.Write("Enter a non-negative integer: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number) && number >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                }
            }

            long factorial = 1;
            int i = number;

            // Calculate factorial using a while loop
            while (i > 1)
            {
                factorial *= i;
                i--;
            }

            Console.WriteLine($"\nFactorial of {number} is: {factorial}");

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
    }
	}
}