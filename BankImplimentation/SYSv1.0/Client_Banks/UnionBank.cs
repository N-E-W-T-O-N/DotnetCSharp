using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SYSv1._0.Client_Banks
{
    internal sealed class UnionBank : IBank
    {
        private string _BankName = "UB";
        private List<Person> Customer = new();
        public string BankName { get => _BankName; }

        public float CheckBalance(int account)
        {
            return Customer.Where(x => x.AccountNumber == account).Select(x => x.Amount).FirstOrDefault();
        }

        public Person CheckUser(string recevierName, int recevierAccountNumber)
        {
            return Customer.FirstOrDefault(x => x.Name == recevierName && x.AccountNumber == recevierAccountNumber);
        }

        public void CreateNewAccount(Person person)
        {
            Customer.Add(person); //Add new customer
           // person.TransactionDetails.Add()
        }

        public void CreditAmount(string Name, int AccountNumber,
                                int AccountPin, float Amount)
        {
            var p = Customer.FirstOrDefault(x => x.AccountNumber == AccountNumber && x.Pincode == AccountPin);
            //Where(x => x.AccountNumber == AccountNumber && x.Pincode ==AccountPin)!=null)
            if (p != null)
            {
                p.Amount += Amount;
                p.TransactionDetails.Add($"Amount credited {Amount} on {DateTime.UtcNow} . Total amount {p.Amount}");
            }
        }
        public void DebitAmount(string Name, int AccountNumber, int AccountPin, float Amount)
        {
            var p = Customer.FirstOrDefault(x => x.AccountNumber == AccountNumber && x.Pincode == AccountPin);
            //Where(x => x.AccountNumber == AccountNumber && x.Pincode ==AccountPin)!=null)
            if (p != null)
            {
                p.Amount -= Amount;
                p.TransactionDetails.Add($"Amount debited {Amount} on {DateTime.UtcNow} . Total amount {p.Amount}");
            }
        }

        public void PrintPassBook(string Name, int AccountNumber, int AccountPin)
        {
            var p = Customer.FirstOrDefault(x => x.AccountNumber == AccountNumber && x.Pincode == AccountPin);
            //Where(x => x.AccountNumber == AccountNumber && x.Pincode ==AccountPin)!=null)
            if (p != null)
            {
                foreach (var s in p.TransactionDetails)
                    Console.WriteLine(s);
                //p.TransactionDetails.Add($"Amount credited {Amount} on {DateTime.UtcNow} . Total amount {p.Amount}");
            }
        }

       

        //Send in same 
        public void TransferWithin(string senderName, int senderAccountNumber, int senderAccountPin, int recevierAccountNumber, float amount)
        {
            var sender = Customer.FirstOrDefault(x => x.AccountNumber == senderAccountNumber && x.Pincode == senderAccountPin);
            //Where(x => x.AccountNumber == AccountNumber && x.Pincode ==AccountPin)!=null)
            if (sender != null)
            {
                if (sender.Amount < amount)
                {
                    Console.WriteLine("You Don't have enought amount to do the transaction");
                  
                }
                else {
                    var receiver = Customer.FirstOrDefault(x => x.AccountNumber == recevierAccountNumber);
                
                        if (receiver != null)
                        {
                        sender.Amount -= amount;
                        receiver.Amount += amount;
                        sender.TransactionDetails.Add($"You have transfer {amount} to {receiver.Name} on {DateTime.UtcNow}");
                        receiver.TransactionDetails.Add($"{amount} has been credited to you by {sender.Name} on {DateTime.UtcNow}");

                        }
                     }
            }
        }

        public void TransferOutside(string senderName, int senderAccountNumber, int senderAccountPin, string recevierName, IBank recieverBank, int recevierAccountNumber, float amount)
        {
         
        var sender = Customer.FirstOrDefault(x => x.AccountNumber == senderAccountNumber && x.Pincode == senderAccountPin);
            //Where(x => x.AccountNumber == AccountNumber && x.Pincode ==AccountPin)!=null)
            if (sender != null)
            {
                if (sender.Amount < amount)
                {
                    Console.WriteLine("You Don't have enought amount to do the transaction");

                }
                else
                {
                    Person recPerson = recieverBank.CheckUser(recevierName, recevierAccountNumber);
                    if (recPerson == null)
                    {
                        Console.WriteLine("No User with this credential");
                    }
                    else
                    {
                        sender.Amount -= 1.05f*amount;
                        recPerson.Amount += amount;
                        sender.TransactionDetails.Add($"You have transfer {amount} to {recPerson.Name} on {DateTime.UtcNow}");
                        recPerson.TransactionDetails.Add($"{amount} has been credited to you by {sender.Name} on {DateTime.UtcNow}");
                    }
                }
            }
        }
    }
}
