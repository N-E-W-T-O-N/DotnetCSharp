using System;
class HelloWorld
{
    static void Main()
    {
        string s = Console.ReadLine();

        var n = s.Length;
        Console.WriteLine(s.Length);


        bool x = true;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != s[n - i - 1])
            {
                x = false;
                break;
            }
        }
        if (x)
        {
            Console.WriteLine("palindrome");
        }
        else
        {
            Console.WriteLine("not palindrome");
        }

    }
}
