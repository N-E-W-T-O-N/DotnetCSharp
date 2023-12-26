using System;//namespace to store 



namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My first program");
            int x = 96;
            var y = "string";
            Console.WriteLine(x+y);
            
            string s = Convert.ToString(x);
            Console.WriteLine("{1} {0}",int.MaxValue,int.MinValue);
            
            Console.WriteLine(5 < 90);
        }
    }
}