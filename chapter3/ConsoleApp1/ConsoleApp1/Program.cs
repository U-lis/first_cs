using System;

namespace ConsoleApp1
{
    class Program {
        static void Main(string[] args) {
            int value = 6;
            int divider = 3;
            int n = value % divider;

            switch (n) {
                case 0:
                    Console.WriteLine(value + " is divided by " + divider);
                    break;
                case 1:
                    Console.WriteLine(value + " remains " + n + " when divided by " + divider);
                    break;
                case 2:
                    Console.WriteLine(value + " remains " + n + " when divided by " + divider);
                    break;
            }


            int[] arr = { 1*2, 2*3, 3*4, 4*5, 5*6 };

            foreach (int i in arr) {
                Console.WriteLine(i);
            }

            /*
             1부터 1000까지의 자연수 중 3의 배수 또는 5의 배수인 수의 합은?
             */
            const int num = 1000;
            int sum = 0;
            for (int i = 1; i <= num; i++) {
                if (num % 3 == 0 || num % 5 == 0) {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}