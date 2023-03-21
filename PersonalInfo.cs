using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_c_
{
    class PersonalInfo : CA
    {
       
        public void BirthDate()
        {
            throw new NotImplementedException();
        }

        public void FirstName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }

        public void Gender()
        {
            throw new NotImplementedException();
        }

        public void LastName()
        {
            throw new NotImplementedException();
        }

        public void Location()
        {
            throw new NotImplementedException();
        }

        public void Nationality()
        {
            throw new NotImplementedException();
        }

    }
}
