using System;

namespace Assignment_02
{
static class Class9
	{
		public static void method()
		{
            int[] numbers = new int[10];

            // Input 10 integers from user
            for (int i = 0; i < numbers.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter integer #{i + 1}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int value))
                    {
                        numbers[i] = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }
            }

            int evenCount = 0;
            int oddCount = 0;

            // Count evens and odds
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine($"\nNumber of even numbers: {evenCount}");
            Console.WriteLine($"Number of odd numbers: {oddCount}");

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
    }
	

}
