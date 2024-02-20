using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        string input;
        string output = "";

        while ((input = Console.ReadLine()) != "exit")
        {
            output += input + " ";
            Console.WriteLine("Enter something:");
        }

        Console.WriteLine(output.Trim());
    }
}
