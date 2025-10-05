using System;

public class Class10
{
	public Class10()
	{
        int[] numbers = new int[10];

        // Input 10 integers into the array
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
                    Console.WriteLine("Invalid input, please enter a valid integer.");
                }
            }
        }

        // Ask user for the number to search
        Console.Write("\nEnter the number to search in the array: ");
        string searchInput = Console.ReadLine();

        if (!int.TryParse(searchInput, out int searchNumber))
        {
            Console.WriteLine("Invalid input for search number.");
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
            return;
        }

        // Linear search
        bool found = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchNumber)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine($"\n{searchNumber} exists in the array.");
        else
            Console.WriteLine($"\n{searchNumber} does not exist in the array.");

        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }
}
}
