// import a namespace called System 
using project_c_;
using System;
using System.Globalization;
using System.Text;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Concurrent;

namespace ConsoleApp1
{
    public class Program
    {
        // ------ FUNCTIONS ------
        // public : Can be accessed from another class
        // private : Can't be accessed from another class
        // protected : Can't be accessed by class and can be accessed by derived classes
        // void, data types
        static void DataTypes()
        {
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

        static void CastingFormating()
        {
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
        }

        static void StringManipulation()
        {
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
                String.Compare("A", "B",
                StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("-------------------------");

            Console.WriteLine(" A = a : {0}",
                String.Equals("A", "a",
                StringComparison.OrdinalIgnoreCase));
            // PadLeft, PadRight, Trim, ToUpper, ToLower,

            string newString = String.Format("{0} saw a {1}",
                "Boar", randString);
            Console.Write(newString + "\n");
            // \' \" \\ \t \a
            Console.WriteLine(@"\n produces new line.");
        }

        static void Arrays()
        {
            // Arrays
            int[] favNums = new int[3];
            string[] customers = { "Bob", "Sally", "Sue" };
            var employees = new[] { "Bob", "Sally", "Sue" };
            object[] allTypes = { "Bob", 1.234, 1234 };

            for (int i = 0; i < allTypes.Length; i++)
            {
                Console.WriteLine("Array {0} has value {1} at position {2}.",
                    "allTypes", allTypes[i], i + 1);
            }

            // Multid Arrays
            string[,] custNames = new string[2, 2] { { "Bob", "Tomi" },
            { "Sally", "Tom" }};
            Console.WriteLine(custNames.GetValue(1, 1));
            for (int x = 0; x < custNames.GetLength(0); x++)
            {
                for (int y = 0; y < custNames.GetLength(1); y++)
                {
                    Console.Write(custNames.GetValue(x, y) + " ");
                }
                Console.WriteLine();
            }

            int[] randNums = { 1, 4, 5, 6, 7 };
            PrintArray(randNums, "lol");
             // IndexOf, SetValue, Copy, CreateInstance, Find
        }

        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, i);
            }
        }

        static void Conditionals()
        {
            // Relational Op : > < >= <= == !=
            // Logical Op : && || !
            if ((1 > 2) && (1 < 2))
            {
                // Do something
            }
            // Ternary Op
            bool canDo = 1 > 2 ? true : false;
            Console.WriteLine(canDo);
            // Switch
            switch (15)
            {
                case 1: 
                    Console.WriteLine("It is 1");
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("No value found.");
                    break;
            }
        }

        static void Loops()
        {
            // for, foreach, while, dowhile
            int i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 9) break;
                Console.WriteLine(i);
                i++;
            }
            i = 1;
            do
            {
                i++;
            } while (i < 10);
            Console.WriteLine(i);
            
        }

        static void StringBuilders()
        {
            StringBuilder sb = new StringBuilder("Random Text");
            StringBuilder sb2 = new StringBuilder("Different Text",256);
            Console.WriteLine("Capacity : {0}", sb2.Capacity);
            Console.WriteLine("Length : {0}", sb2.Length);
            sb2.AppendLine("\nMore important text.");
            
            // Append, AppendFormat, Replace, Insert, Remove, Clear
        }

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        
        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Black,
            Yellow
        }

        static void PaintCar(CarColor color)
        {
            Console.WriteLine("The car was painted {0} with the code {1}",
                color, (int)color);
        }

        public static void Structs()
        {
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine(rect1.Area());

            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine(rect2.length);
            Console.WriteLine(rect1.length);

            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaw"
            };
            Console.WriteLine("# of Animals is {0}",
                Animal.GetNumAnimals());
        }

        public static void WatchingTV()
        {
            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powBut = new PowerButton(TV);

            powBut.Execute();
            powBut.Undo();
            powBut.Execute();
            powBut.Undo();
        }

        public static void ErrorHandling()
        {
            // Exception Handling
            try
            {
                int solution; int num1 = 5; int num2 = 10;
                Swap(ref num1, ref num2);
                Console.WriteLine("num1 is now {0} : num2 is now {1}", num1, num2);

                DoubleIt(10, out solution);
                Console.WriteLine("Double of 10 is {0}.", solution);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Console.WriteLine("Handling the error!");
                CarColor car1 = CarColor.Blue;
                PaintCar(car1);
                WatchingTV();
            }
        }

        public static void ListArray() 
        {
            ArrayList aList = new ArrayList();

            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine("Count : {0}", aList.Count);
            Console.WriteLine("Capacity : {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            aList.AddRange(aList2);
            // Sort, Reverse, RemoveAt, RemoveRange, Insert, IndexOf, ToArray,
        }
        // ------ END OF FUNCTIONS ------

        // Struct
        struct Rectangle
        {
            public double length;
            public double width;

            // Struct Method
            public Rectangle(double l = 1, double w = 1) { length = l; width = w; }
            public double Area()
            {
                return length * width;
            }
        }
        // 

        static void Main(string[] args)
        {
            #region Init Code
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            // Dates
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Current time {0}", dateTime);

            // Reading / Writing args
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            #endregion  


        }
    }
}