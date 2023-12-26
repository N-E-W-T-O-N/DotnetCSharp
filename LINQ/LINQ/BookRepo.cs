namespace LINQ
{
    public class BookRepo
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book(){Title = "Hello",Price =10f},
                new Book(){Title="World",Price=13.4f},
                new Book(){Title="C# book ",Price=9.99f}
            };
        }
    }
}