namespace Program
{
    public class Employee
    {
        public bool IsBirthDay(DateTime dt,int n=30)
        {
            var x = dt.DayOfYear;// .CompareTo(DateTime.Now);
            var y = DateTime.Now.DayOfYear;
            if (x < y) return false; //Date already went
            else if (x -y <= n) return true; //Lease Within n dates
            else return false; //Acced n days
        }
    }

    public class P
    {
        public static void Main(string[] args)
        {
            Employee employee = new ();
            bool t =employee.IsBirthDay(new DateTime(1978,02,01)); //Lie
            Console.WriteLine(t);
            t = employee.IsBirthDay(new DateTime(1978, 07, 01)); //Exceed
            Console.WriteLine(t);
            t = employee.IsBirthDay(new DateTime(1978, 01, 01),5); //Already Passed
            Console.WriteLine(t);
        }
    }
}
