using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        static public int PersonCount = 0;
        string _name;

        public Person(string name) {
            PersonCount++;
            _name = name;
        }

        public void WriteName() {
            Console.WriteLine("Name: " + _name);
        }

        public void GetPersoncount() { 
            Console.WriteLine(PersonCount);
        }
    }
}
