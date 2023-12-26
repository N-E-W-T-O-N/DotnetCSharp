using PersonAge;

namespace Prop
{
    class Program
    {
        static void Main(String[] args)
        {
            var pers = new Person();

            pers.BirthDay = new DateTime(1999, 12, 31);
            Console.WriteLine(pers.BirthDay);
            Console.WriteLine(pers.age);
        }
    }
}
