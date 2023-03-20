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

            double biggestDouble = double.MaxValue; 

            float biggestFloat = float.MaxValue;

            Console.WriteLine("Biggest Integer : {0}", biggestInt);
            Console.WriteLine("Biggest Long : {0}", biggestLong);
            Console.WriteLine("Biggest Decimal : {0}", biggestDecimal);
            Console.WriteLine("Biggest Double : {0}", biggestDouble);
            Console.WriteLine("Biggest Float : {0}", biggestFloat);
        }
    }
}