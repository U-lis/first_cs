using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mammal
    {
        public void Move() {
            Console.WriteLine("Mammal Move");
        }
    }

    internal class Lion : Mammal {
        public void Move() {
            Console.WriteLine("Move with four legs");
        }
    }
    internal class Whale : Mammal { 
        public void Move() {
            Console.WriteLine("Swim!");
        }
    
    }
    internal class Human: Mammal { 
        public void Move() {
            Console.WriteLine("Move with two legs");
        }
    }
}
