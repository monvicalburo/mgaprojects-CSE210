using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string gradeFromUser = Console.ReadLine();
        int x = int.Parse(gradeFromUser);

        if (x >= 90)
        {
            Console.WriteLine("A");
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else if (x >= 80)
        {
            Console.WriteLine("B");
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else if (x >= 70)
        {
            Console.WriteLine("C");
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else if (x >= 60)
        {
            Console.WriteLine("D");
            Console.WriteLine("You failed the course.");
        }
        else
        {
            Console.WriteLine("F");
            Console.WriteLine("You failed the course.");
        }
    }
}