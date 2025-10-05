using System;

namespace Assignment_02
{
	public class Class8
	{
		public Class8()
		{
            int[] numbers = new int[10];

            // Input 10 integers from the user
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

            // Initialize max and min with the first element
            int max = numbers[0];
            int min = numbers[0];

            // Loop through the array to find max and min
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];

                if (numbers[i] < min)
                    min = numbers[i];
            }

            Console.WriteLine($"\nMaximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
    }

}
