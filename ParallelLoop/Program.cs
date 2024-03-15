using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //Choose a large number 
        int[] numbers = Enumerable.Range(1, 100).ToArray(); 
        int[] squares = new int[numbers.Length];

        // Parallel loop to calculate squares
        Parallel.For(0, numbers.Length, i =>
        {
            squares[i] = numbers[i] * numbers[i];
            Console.WriteLine($"Square of {numbers[i]} is {squares[i]}");
        });

        Console.WriteLine("All squares calculated.");
    }
}
