// import a namespace called System 
using System;

namespace ConsoleApp1
{
    public class Program
    {
        // This function can run before
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            // Data types
            bool canI = true; //false

            int biggestInt = int.MaxValue;

            long biggestLong = long.MaxValue;

            decimal biggestDecimal = decimal.MaxValue;


        }
    }
}