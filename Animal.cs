using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_c_
{
    class Animal
    {
        private string name;
        private string sound;
        static int numOfAnimals = 0;

        // Initialization through a constructor - constructor has the same name as the class
        public Animal() 
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name", string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;

            numOfAnimals++;
        }

        public void MakeSound() 
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }

        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            } else
            {
                this.name = "No Name";
                Console.WriteLine("Name can't contain numbers.");
            }
        }

        public string GetName()
        {
            return name;
        }

        public string Sound
        {
            get { return sound; }
            set 
            { 
                sound = value; 
            }
        }

        public string Owner { get; set; } = "No Owner";

        public static int numOf
    }
}
