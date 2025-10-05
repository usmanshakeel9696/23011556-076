using System;

namespace Assignment_02
{
	public class Class7
	{
		public Class7()
		{
            int number = int.Parse(Console.ReadLine());

            int reversed = 0;

            while (number != 0)
            {
                int digit = number % 10;     
                reversed = reversed * 10 + digit;  
                number /= 10;                
            }

            Console.WriteLine($"Reversed number is: {reversed}");

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
    }
	}
}