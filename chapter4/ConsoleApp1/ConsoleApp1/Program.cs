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
            Console.WriteLine("Person Count: " + Person.PersonCount);
            Person p2 = new Person("arstarst");
            Console.WriteLine("Person Count: " + Person.PersonCount);

            // Codes for Person2: Singleton
            // Person2 pp = new Person2("Not President");  // This cannot be done
            Person2.President.DisplayName();
        }
    }

    class Math {
        public int f(int x) {
            return x * x;
        }
    }
}
