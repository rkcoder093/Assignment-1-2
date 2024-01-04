using System;

class Program1
{ 
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int numberOfRows ;
        if (int.TryParse(Console.ReadLine(), out numberOfRows ))
        {
            PrintTrianglePattern(numberOfRows);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void PrintTrianglePattern(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
