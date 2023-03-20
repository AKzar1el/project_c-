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

            // Reading / Writing args
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

            // Casting
            double dblFromStr = double.Parse("1.234");
            string strVal = dblFromStr.ToString();
            Console.WriteLine($"Data type : {strVal.GetType()}");
            Console.WriteLine($"Integer : {(int)dblFromStr}");

            // Formating
            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.45555);
            Console.WriteLine("Commas : {0:n4}", 2300);

            // String manipulation
            string randString = "This is a string";
            Console.WriteLine("String Length : {0}",
                randString.Length);
            Console.WriteLine("String Contains is : {0}",
                randString.Contains("is"));
            Console.WriteLine("Index of is : {0}",
                randString.IndexOf("is"));
            Console.WriteLine("Remove String : {0}",
                randString.Remove(10, 6));
            Console.WriteLine("Insert String : {0}",
                randString.Insert(10, "Short "));
            Console.WriteLine("Replace String : {0}",
                randString.Replace("string", "sentence"));
            Console.WriteLine("Compare A to B, {0}",
                String.Compare("A","B",
                StringComparison.OrdinalIgnoreCase));
        }
    }
}