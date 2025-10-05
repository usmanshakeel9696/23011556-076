using System;
namespace Assignment_02 
{
    public class Class4
    {
        public Class4()
        {
            // Ask user for a valid number
            while (true)
            {
                Console.Write("Enter a positive integer: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int n) && n > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive number.");
                }
            }

            int sum = 0;

            // For loop to calculate sum
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of numbers from 1 to {n} is: {sum}");

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        } }
}
}
