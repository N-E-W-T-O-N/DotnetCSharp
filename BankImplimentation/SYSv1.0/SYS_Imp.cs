using System.Transactions;
using SYSv1._0.Client_Banks;

namespace SYSv1
{
    public class SYS_Imp
    {
        private readonly Dictionary<string, IBank> bankClient = new() //Dictionary<string, IBank>
                {
                { "UB", new UnionBank() }  ,
            {"INDB",new IndianBank() }
               };

        //b1 = new UnionBank();
        //private Dictionary<string, int> Bank_Id;
        public SYS_Imp()
        {
            Console.WriteLine("WELCOME TO Sys1.00");
            Console.WriteLine("WE HAVE TO BANKS\n1) INDIANBANK(INDB) \n2)UNION BANK(UB)");

        }

        public void NewAccount(string Name, String BankName, int AccountNumber,
                                int AccountPin, float Amount)
        {
            if (bankClient[BankName] == null)
            {
                Console.WriteLine("Sorry But This Bank Dont Exist");
            }
            else
            {
                var p = new Person(Name, AccountNumber, AccountPin, Amount);
                bankClient[BankName].CreateNewAccount(p);
            }

        }
        public void Balance(string Name, String BankName, int AccountNumber,
                                int AccountPin)
        {
            if (bankClient[BankName] == null)
            {
                Console.WriteLine("Sorry But This Bank Dont Exist");
            }
            else
            {
                bankClient[BankName].CheckBalance(AccountNumber);
            }
        }
        public void Credit(string Name, String BankName, int AccountNumber,
                                int AccountPin, float Amount)
        {
            if (bankClient[BankName] == null)
            {
                Console.WriteLine("Sorry But This Bank Dont Exist");
            }
            else
            {
                bankClient[BankName].CreditAmount(Name, AccountNumber, AccountPin, Amount);
            }
        }

        public void Dedit(string Name, String BankName, int AccountNumber,
                                int AccountPin, float Amount)

        {
            if (bankClient[BankName] == null)
            {
                Console.WriteLine("Sorry But This Bank Dont Exist");
            }
            else
            {
                bankClient[BankName].DebitAmount(Name, AccountNumber, AccountPin, Amount);
            }
        }

        public void Transaction(string Name, String BankName, int AccountNumber,
                                int AccountPin)
        {
            if (bankClient[BankName] == null)
            {
                Console.WriteLine("Sorry But This Bank Dont Exist");
            }
            else
            {
                Console.WriteLine($"\n================\nHELLO {Name} \n================\n");
                bankClient[BankName].PrintPassBook(Name, AccountNumber, AccountPin);
            }
        }

        //("PRINCE", "UB", 11111, 2204, 22222, 555.f);
        //same account
        public void Transfer(string SenderName, string BankName, int SenderAccountNumber,
                                int SenderAccountPin, string RecevierName, int RecevierAccountNumber, float amount)
        {//Same Account 
            if (bankClient[BankName] == null)
            {
                Console.WriteLine("Sorry But This Bank Dont Exist");
            }
            else
            {
                bankClient[BankName].TransferWithin(SenderName, SenderAccountNumber, SenderAccountPin
                    , RecevierAccountNumber, amount);
            }
        }

        public void Transfer(string SenderName, string SenderBankName, int SenderAccountNumber, int SenderAccountPin,
                                string RecevierName, string RecevierBankName, int RecevierAccountNumber, float amount)
        {
            if (bankClient[SenderBankName] == null)
            {
                Console.WriteLine("Sorry But This Bank Dont Exist");
            }
            else
            {
                //Person recP = bankClient[RecevierBankName].CheckUser(RecevierName, RecevierAccountNumber);
                    /*if (recP == null)
                    {
                        Console.WriteLine("No User with this credential");
                    }*/

                
                    bankClient[SenderBankName].TransferOutside(SenderName, SenderAccountNumber, SenderAccountPin,
                                 RecevierName, bankClient[RecevierBankName], RecevierAccountNumber, amount);
            
            }
        }
    }
}