using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_c_
{
    class Person
    {
        public string Name { get; set; }
        static int UiD = 0;
        public string Age { get; }
        
        public Person(string name = "No Name", string age = "0") 
        { 
            Name = name; 
            UiD++;
            Age = age;
        }

        public static int GetSum()
        {
            return UiD;
        }
    }
}
