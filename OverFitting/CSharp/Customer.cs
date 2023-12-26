namespace CSharp
{
    public class Customer
    {
        public int Id;
        public string Name;

        public Customer(int Id , string Name) {
            this.Id = Id;
            this.Name =Name;
        }
        public Customer(int Id)
        {
            this.Id = Id;
            this.Name = "LOL";
        }

        public Customer(string Name) { this.Name = Name;
            this.Id = 0;

        }
        public void Intro()
        {
            Console.WriteLine($"Customer ID {this.Id} \t Customer NAme {this.Name}");
        }
    }
}