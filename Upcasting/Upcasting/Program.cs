/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/

using System;

namespace program
{
    public class A
    {
        public void m()
        {
            Console.WriteLine("Base M is called");

        }
    }
    public class B : A
    {
        public new void m()
        {
            Console.WriteLine("Derived M is called");
        }
    }
    public class HelloWorld
    {
        static void Main()
        {
            A x = new B();  //Upcasting  

            B y = new B();

            x.m(); //Base m
            y.m(); // Derived m

        }
    }
}
