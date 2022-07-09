using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        string _name;

        public Person(string name) {
            _name = name;
        }

        public void WriteName() {
            Console.WriteLine("Name: " + _name);
        }
    }
}
