using System;
namespace Random
{
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            int intVal;
            Console.Write("Enter integer value:");
            userInput = Console.ReadLine();
            /* Converts to integer type */
            intVal = Convert.ToInt32(userInput);
            Console.WriteLine("You entered {0}", intVal);

            //Console.WriteLine("Enter the number");
            
            

            var sum = 1;
            while (intVal > 0)
            {
                sum = sum*intVal;
                intVal--;
            }


            Console.WriteLine("Sum is {0}", sum);
            Console.ReadKey();
        }
    }
}
