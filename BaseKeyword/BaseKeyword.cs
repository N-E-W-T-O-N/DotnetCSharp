/*******************************************************************************/
using System;
//Use of base class
public class C1 
{
    public C1(int X)
    {
        this.x = X ;
    }
    protected int x {get ;set ;}
}
public class C2:C1 
{
    protected int  Y ;
    public C2(int x,int y):base(x)
    {
        
        this.Y = y ; 
    }

    public void print()
    {
        Console.WriteLine($"Base Class Value => {base.x}") ;
        Console.WriteLine($"Derived Class Value => {this.Y}") ;
    }
}
class HelloWorld {
  static void Main() {
    //Console.WriteLine("Hello World");
    var c =new C2(2,4) ;
    
    c.print() ;
    //c.M1(2) ;
  }
}