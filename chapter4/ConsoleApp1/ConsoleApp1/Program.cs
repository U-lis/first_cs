using Communication;
using Disk.FileSystem;

namespace ConsoleApp1
{
    class Program
    {
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
        }
    }

    class Math {
        public int f(int x) {
            return x * x;
        }
    }
}
