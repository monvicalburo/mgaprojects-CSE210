using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string response = Console.ReadLine();
            guess = int.Parse(response);


            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You Guessed it!");
            }
        }
    }
}