using System.ComponentModel.DataAnnotations;

namespace SYSv1
{
    public class Person
    {
        private string _name; //Name of user 
        private int _accountNumber; //Respective User number
        private int _accountPin;//Account pin
        private float _amount;//amount 
        public List<string> TransactionDetails { get; set; } = new();//Store all information

        public string Name { get => _name; set => _name = value; }
        public int AccountNumber { set => _accountNumber = value; get { return _accountNumber; } }
        public int Pincode { get => _accountPin; set => _accountPin = value; }
        public float Amount { get => _amount; set { if (value < 0) { Console.WriteLine("Value cannot be neagative "); } else _amount = value; } }
        //public string BankName { get; set; }
 
        // public string this[string s] =>CheckBank(BankName);

        public Person(string name, int accountNumber, int accountPin, float amount = 0)
        {
            this.Name = name;
            this.AccountNumber = accountNumber;
            this.Pincode = accountPin;
            this.Amount = amount;
            this.TransactionDetails.Add($"Your Account is been Created on {DateTime.UtcNow} with initial Amount {Amount}");
        }
    }
        
}