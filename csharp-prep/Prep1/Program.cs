using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");
        Console.Write("What is your First Name ?: ");
        string Firstname = Console.ReadLine();
        Console.Write("What is your Last Name ? : ");
        string Lastname = Console.ReadLine();
        Console.WriteLine($"Your Full name is : {Firstname} {Lastname}");
        Console.WriteLine($"Thanks so much {Firstname} {Lastname} for playing my game");
        Console.WriteLine("Good Bye.");
    }
}