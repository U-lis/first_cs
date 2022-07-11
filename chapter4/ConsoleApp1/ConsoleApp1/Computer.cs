using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Notebook {
        bool powerOn;
        public void Boot() { }
        public void ShutDown() { }
        public void Reset() { }

        bool fingerScan;
        public bool HasFinderScanDevice() {
            return fingerScan;
        }
    }

    internal class Desktop { 
        bool powerOn;
        public void Boot() { }
        public void ShutDown() { }
        public void Reset() { }
        
    }

    internal class Netbook { 
        bool powerOn;
        public void Boot() { }
        public void ShutDown() { }
        public void Reset() { }
    }
}
