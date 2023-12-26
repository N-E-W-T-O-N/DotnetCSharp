/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
namespace program
{

    interface IShape
    {
        float area();
    }

    public class Rectangle : IShape
    {
        private float _x, _y;

        public Rectangle(float a, float b)
        {
            _x = a;
            _y = b;
        }

        public float area()
        {
            return _x * _y;
        }
    }

    public class Circle : IShape
    {
        private float _radius;
        public Circle(float radius) { _radius=radius; }
        public float area()
        { 
            return 3.1416f*_radius * _radius;
        }
    }
    class HelloWorld
    {
        static void Main()
        {
            IShape s1 = new Rectangle(12.0f, 23.4f);
            IShape s2= new Circle(12);
            Console.WriteLine(s1.area());
            Console.WriteLine(s2.area());
        }
    }

}
