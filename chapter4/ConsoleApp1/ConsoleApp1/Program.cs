namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) {
            // Codes for Book
            Book gulliver = new Book();

            gulliver.Title = "걸리버 여행기";
            gulliver.Author = "Jonathan Swift";
            gulliver.ISBN13 = 9788983920775m;
            gulliver.Contents = "contents";
            gulliver.PageCount = 384;


            // Codes for Math
            Math m = new Math();
            int result = m.f(10);
            Console.WriteLine(result);

            // Codes for Person
            Person p = new Person("arst");
            p.WriteName();
        }
    }

    class Book
    {
        public string Title;
        public decimal ISBN13;
        public string Contents;
        public string Author;
        public int PageCount;
    }

    class Math {
        public int f(int x) {
            return x * x;
        }
    }
}
