using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PrimeCallbackArg: EventArgs {
        public int Prime;

        public PrimeCallbackArg(int prime) {
            Prime = prime;
        }
    }

    class PrimeGenerator {
        public event EventHandler PrimeGenerated;

        public void Run(int limit) {
            for (int i = 2; i <= limit; i++) {
                if (IsPrime(i) && PrimeGenerated != null) {
                    PrimeGenerated(this, new PrimeCallbackArg(i));
                }
            }
        }

        private bool IsPrime(int candidate) {
            if ((candidate & 1) == 0) {
                return candidate == 2;
            }

            for (int i = 3; (i * i) <= candidate; i += 2) {
                if ((candidate % i) == 0) return false;
            }

            return candidate != 1;
        }
    }
}
