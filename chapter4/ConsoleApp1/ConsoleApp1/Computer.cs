using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Computer { 
        protected bool powerOn;
        virtual public void Boot() {
            Console.WriteLine("Turn on hardware");
        }
        public void ShutDown() { 
            Console.WriteLine("Shut Down");
        
        }
        public void Reset() { 
            Console.WriteLine("Reset");
        }
    }

    internal class Notebook: Computer {
        bool fingerScan;
        public bool HasFinderScanDevice() {
            return fingerScan;
        }
        public void CloseLid() {
            if (powerOn) {
                ShutDown();
            }
        }

        override public void Boot() {
            base.Boot();
            Console.WriteLine("Turn on monitor");
        }
    }

    internal class Desktop: Computer { 
        
    }

    internal class Netbook: Computer { 
    }
}
