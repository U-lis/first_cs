using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate int GetResultDelegate();
    class Target {
        public void Do(GetResultDelegate getResult) {
            getResult();
        }
    }

    class Source {
        public int GetResult() {
            return 10;
        }

        public void Test() {
            Target target = new Target();
            target.Do(new GetResultDelegate(this.GetResult));
        }
    }
}
