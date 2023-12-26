namespace O
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var x = new Comp(3, 4);
            var y = new Comp(4, 5);
            Console.WriteLine($"X = {x}");

            Console.WriteLine(x.Real);
            Console.WriteLine(x.Img);
            Console.WriteLine(x.Mod);
            Console.WriteLine($"Y = {y}");
            var z = x + y;
            
            var a = x - y;
            var b = x * y;
            var c = x / y;

            y*=3; //Here
            Console.WriteLine($"{ y.Real} {y.Img}");
            x*=3;//here

            Console.WriteLine($"{x.Real} {x.Img}");
            x--;
            Console.WriteLine($"{x.Real} {x.Img}");
            --x;
            Console.WriteLine($"{x.Real} {x.Img}");
            ++x;
            Console.WriteLine($"{x.Real} {x.Img}");

            x =-x; //here in c++ ucan use -x
            Console.WriteLine($"{x.Real} {x.Img}");

            Console.WriteLine($"Z = {z}");
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine($"C = {c}");
            //x=x-; //here in C++ uhave to devi operatior as operator -(int) where that operatior work as dommy
            //Console.WriteLine($"{x.Real} {x.Img}");

        }
    }


