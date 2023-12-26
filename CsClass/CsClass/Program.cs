using System;

namespace FirstClass
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.FirstName = "John";
            p.LastName = "Sigma";
            p.Intro();

            var n =new int[3] {7,8,9 };

            //Console.WriteLine(n[0]);
            string s = String.Join(" ", n);
            Console.WriteLine(s);
            string x = "Hello" + " " + "World";
            Console.WriteLine(x);

        }
    }
}