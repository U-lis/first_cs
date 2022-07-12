using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Currency
    {
        decimal money;
        public decimal Money {
            get { return money; }
        }
        public Currency(decimal money) {
            this.money = money;
        }
    }

    internal class Won : Currency
    {
        public Won(decimal money) : base(money) {
        }

        public override string ToString() {
            return Money + " won";
        }

        public static implicit operator Won(Yen yen) {
            return new Won(yen.Money * 13m);
        }
    }

    internal class Dollar : Currency
    {
        public Dollar(decimal money) : base(money) { }
        public override string ToString() {
            return Money + " dollar";
        }
    }

    internal class Yen : Currency
    {
        public Yen(decimal money) : base(money) { }

        public override string ToString() {
            return Money + " Yen";
        }
    }
}
