using System;

namespace Assignment_02
{
static class Class3
{
   public static void method()
	
       
        {
            Console.WriteLine("Grade Evaluator");

            Console.Write("Enter your marks (0–100): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int marks))
            {
                if (marks < 0 || marks > 100)
                {
                    Console.WriteLine("Error: Marks must be between 0 and 100.");
                }
                else
                {
                    string grade;

                    if (marks >= 85)
                        grade = "A";
                    else if (marks >= 70)
                        grade = "B";
                    else if (marks >= 55)
                        grade = "C";
                    else if (marks >= 40)
                        grade = "D";
                    else
                        grade = "F";

                    Console.WriteLine($"Your grade is: {grade}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

}
