using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kilogram
    {
        double mass;

        public Kilogram(double value) {
            mass = value;
        }

        public Kilogram Add(Kilogram target) {
            return new Kilogram(this.mass + target.mass);
        }

        public override string ToString() {
            return mass + " kg";
        }
    }
}
