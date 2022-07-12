using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mathematics
    {
        delegate int CalcDelegate(int x, int y);

        public static int Add(int x, int y) { Console.WriteLine(x + y);  return x+y; }
        public static int Subtract(int x, int y) { Console.WriteLine(x - y);  return x - y; }
        public static int Multiply(int x, int y) { Console.WriteLine(x * y);  return x*y; }
        public static int Divide(int x, int y) { Console.WriteLine(x / y);  return x / y; }

        CalcDelegate[] methods;

        public Mathematics() {
            methods = new CalcDelegate[] { Mathematics.Add, Mathematics.Subtract, Mathematics.Multiply, Mathematics.Divide };
        }

        public void Calculate(char opCode, int operand1, int operand2) {
            switch (opCode) {
                case '+':
                    methods[0](operand1, operand2);
                    break;
                case '-':
                    methods[1](operand1, operand2);
                    break;
                case '*':
                    methods[2](operand1, operand2);
                    break;
                case '/':
                    methods[3](operand1, operand2);
                    break;

            }
        }
    }
}
