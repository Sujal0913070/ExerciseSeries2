using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number == 0)
        {
            Console.WriteLine("The number is zero.");
        }
        else if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is negative.");
        }

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }
}
