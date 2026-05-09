using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());


            if (guess < number)
            {
                Console.Write("Higher");
            }
            else if (guess > number)
            {
                Console.Write("Lower");
            }
            else
            {
                Console.Write("You Guessed it!");
            }
        }  
    }
}