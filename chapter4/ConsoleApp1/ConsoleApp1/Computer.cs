using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Computer { 
        protected bool powerOn;
        public void Boot() {
            Console.WriteLine("Boot");
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
    }

    internal class Desktop: Computer { 
        
    }

    internal class Netbook: Computer { 
    }
}
