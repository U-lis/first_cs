using Communication;
using Disk.FileSystem;

namespace ConsoleApp1
{
    class Program
    {
        // Codes for delegate
        // 매개변수 3개 받고 void return 하는 delegate 선언.
        // delegate 이름이나 인자명은 사실 맘대로 해도 된다. 약간 추상화 느낌.
        delegate void WorkDelegate(char arg1, int arg2, int arg3);
        delegate int CalcDelegate(int arg2, int arg3);

        // Codes for event
        static void PrintPrime(object sender, EventArgs arg) {
            Console.Write((arg as PrimeCallbackArg).Prime + ", ");
        }

        static int Sum;
        static void SumPrime(object sender, EventArgs arg) {
            Sum += (arg as PrimeCallbackArg).Prime;
        }

        static void Main(string[] args) {
            // Codes for Book
            Book gulliver = new Book("걸리버");
            Book huckleberry = new Book("허클베리 핀", 1234567890m);
            Book alice = new Book("이상한 나라의 앨리스", 9876543210m, "Lewis Carroll");


            // Codes for Math
            Math m = new Math();
            int result = m.f(10);
            Console.WriteLine(result);

            // Codes for Person
            Person p = new Person("arst");
            p.WriteName();
            //Console.WriteLine("Person Count: " + Person.PersonCount);
            Person.GetPersonCount();
            Person p2 = new Person("arstarst");
            //Console.WriteLine("Person Count: " + Person.PersonCount);
            Person.GetPersonCount();

            // Codes for Person2: Singleton
            // Person2 pp = new Person2("Not President");  // This cannot be done
            Person2.President.DisplayName();


            // Codes for namespace
            MilkyWay.Earth e1 = new MilkyWay.Earth();
            Andromeda.Earth e2 = new Andromeda.Earth();

            Http http = new Http();
            Ftp ftp = new Ftp();
            File_ file = new File_();

            // Codes for property
            Circle o = new Circle();
            o.Pi = 3.14159265;
            double piValue = o.Pi;
            Console.WriteLine(piValue);


            // Codes for inheritance
            Netbook netbook = new Netbook();
            netbook.Boot();

            // Codes for as, is
            Computer com = new Computer();
            Notebook notebook = com as Notebook;

            if (notebook != null) {
                notebook.CloseLid();
            }

            // This code will not be compiled
            //int n = 5;
            //if ((n as String) != null) {
            //    Console.WriteLine("n is string type");
            //}

            // This code will not be compiled
            //string txt = "string";
            //if ((txt as int) != null) {
            //    Console.WriteLine("txt is int type");
            //}

            int n = 5;
            if (n is string) { 
                Console.WriteLine("n is string type");
            }
            string txt = "string";
            if (txt is int) {
                Console.WriteLine("txt is int type");
            }

            // Codes for polymorphism
            Lion lion = new Lion();
            Whale whale = new Whale();
            Human human = new Human();

            lion.Move();
            whale.Move();
            human.Move();

            Mammal lion2 = lion;
            lion2.Move();

            Notebook notebook2 = new Notebook();
            notebook2.Boot();

            // Codes for operator overload
            Kilogram kg1 = new Kilogram(10);
            Kilogram kg2 = new Kilogram(15);
            Kilogram kg3 = kg1.Add(kg2);
            Console.WriteLine(kg3.ToString());
            Kilogram kg4 = kg1 + kg2;
            Console.WriteLine(kg4.ToString());

            // Codes for type casting between classes
            Won won = new Won(1000);
            Dollar dollar = new Dollar(1);
            Yen yen = new Yen(13);

            // This makes compile time error
            won = yen;  // Can do implicit
            won = (Won)yen;  // Can do explicit
            Console.WriteLine(won.ToString());

            //Won won1 = dollar;  // Cannot do implicit type casting
            Won won2 = (Won)dollar; // Only can do explicit type casting
            Console.WriteLine(won2.ToString());

            // Codes for abstract class
            DrawingObject line = new Line(new Point(10, 10), new Point(20, 20));
            line.Draw();
            line.Move();

            // Codes for delegate
            Mathematics math = new Mathematics();
            WorkDelegate work = math.Calculate;

            work('+', 10, 5);
            work('-', 10, 5);
            work('*', 10, 5);
            work('/', 10, 5);

            CalcDelegate calc = Mathematics.Add;
            calc += Mathematics.Subtract;
            calc += Mathematics.Multiply;
            calc += Mathematics.Divide;

            calc(10, 5);

            calc -= Mathematics.Multiply;
            calc(10, 5);

            // Codes for event
            //// Code with delegate
            PrimeGenerator gen = new PrimeGenerator();
            gen.PrimeGenerated += PrintPrime;
            gen.PrimeGenerated += SumPrime;
            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(Sum);

            gen.PrimeGenerated -= SumPrime;
            gen.Run(15);
            Console.WriteLine();

            // Codes for indexer
            IntegerText aInt = new IntegerText(123456);
            int step = 1;
            for (int i = 0; i < aInt.ToString().Length; i++) {
                Console.WriteLine(step + " 의 자릿수: " + aInt[i]);
                step *= 10;
            }

            aInt[3] = '1'; // 1 based index
            Console.WriteLine(aInt.toInt32());
        }
    }

    class Math {
        public int f(int x) {
            return x * x;
        }
    }
}
