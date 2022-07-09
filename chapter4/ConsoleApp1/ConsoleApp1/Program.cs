namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) {
            Book gulliver = new Book();

            gulliver.Title = "걸리버 여행기";
            gulliver.Author = "Jonathan Swift";
            gulliver.ISBN13 = 9788983920775m;
            gulliver.Contents = "contents";
            gulliver.PageCount = 384;
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
