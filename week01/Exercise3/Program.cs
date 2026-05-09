using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int x = int.Parse(magicNumber);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int y = int.Parse(guess);

        if (y < x)
        {
            Console.WriteLine("Higher");
        }
        else if (y > x)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You Guessed it!");
        }

    }
}