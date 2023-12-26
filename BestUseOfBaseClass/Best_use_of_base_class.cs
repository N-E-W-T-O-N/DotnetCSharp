// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var bc = new DerivedClass(5);  //Here 5 is store in base class and can be call multiple time , instead of using a staatic value 
        bc.PrintQue();
    }
}

public class BaseClass
{
    public BaseClass(int x)
    {
        Count = x;
    }
    public int Count { get; set;}
    
    public void PrintQue()
    {
        Console.WriteLine(Count);
    }
    
}
public class DerivedClass : BaseClass
{
    public DerivedClass(int x):base(x)
    {
        
    }
   
}