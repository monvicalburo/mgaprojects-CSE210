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
        }
        else if (x >= 80)
        {
            Console.WriteLine("B");
        }
        else if (x >= 70)
        {
            Console.WriteLine("C");
        }
        else if (x >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
        if (x >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("You failed the course!");
        }
    }
}