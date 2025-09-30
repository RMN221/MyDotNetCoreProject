// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        GreetUser("User");
        Farewell("User");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    static void Farewell(string name)
    {
        Console.WriteLine($"Goodbye, {name}!");
    }
}
