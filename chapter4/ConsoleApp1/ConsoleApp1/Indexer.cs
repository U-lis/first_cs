using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IntegerText
    {
        char[] txtNumber;

        public IntegerText(int number) {
            this.txtNumber = number.ToString().ToCharArray();
        }

        public char this[int index] {
            get {
                return txtNumber[txtNumber.Length - index - 1];
            }
            set { 
                txtNumber[txtNumber.Length - index - 1] = value;
            }
        }

        public override string ToString() {
            return new string(txtNumber);
        }

        public int toInt32() { 
            return Int32.Parse(ToString());
        }
    }
}
