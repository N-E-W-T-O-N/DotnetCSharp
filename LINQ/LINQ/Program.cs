using System.Security.Cryptography.X509Certificates;

namespace LINQ
{

    public class Program
    {
        static void Main(string[] args)
        {
            var b = new BookRepo().GetBooks();
            //LINQ Query OPerators

            //LINQ Extension Methods
            foreach (var item in b.Where(b=>b.Price>5).OrderBy(z=>z.Title))
            {
                Console.WriteLine($"Title = {item.Title}\tPrice = {item.Price} $");
            }
        }
    }
}