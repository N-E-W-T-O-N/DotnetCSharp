namespace CSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var A = new Customer(1, "SAM_sol");
            var B = new Customer(23);
            var C = new Customer("alal");
            A.Intro();
            B.Intro();
            C.Intro();
        }
    }
}