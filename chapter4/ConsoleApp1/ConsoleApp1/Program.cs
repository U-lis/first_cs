namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) {
            Book gulliver = new Book();
        }
    }

    class Book
    {
        string Title;
        decimal ISBN13;
        string Contents;
        string Author;
        int PageCount;
    }
}
