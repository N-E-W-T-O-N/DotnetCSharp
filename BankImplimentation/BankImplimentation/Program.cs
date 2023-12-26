using System;
using System.Xml.Linq;
using SYSv1;
using SYSv1._0;

namespace ConsoleApp3

{
    internal class Program
    {
        static void Main(string[] args)

        {

            //Bank is created
            /*IBank indianBank = new Bank();
            IBank unionBank = new Bank();*/

            //INDB
            //UB
            var s = new SYS_Imp();//Use to access the SYS_Imp portal

            s.NewAccount( "PRINCE",  //Name
                                "UB", //Bank Name
                                11111 , //AccountNumber
                                2204, //PinCode
                                123.34f);//First Deposit
            s.NewAccount("KING", "INDB", 0000, 2434, 55443.34f);
            s.NewAccount("RAJA", "UB", 22222, 1234, 0);

            /*s.CreateNewAccount(new Person {  Name = "Faiz",BankName="INDB",
                                    AccountNumber = 1212 ,Amount= 123.34 });
            s.CreateNewAccount(new Person { Name = "Akram", Amount = 90877.56 });
            s.CreateNewAccount(new Person { Name = "Prince", BankName = "" }) ;*/
            s.Credit("PRINCE", "UB", 11111, 2204, 2243f);
            s.Credit("PRINCE", "UB", 11111, 2204, 42433.5f);
            s.Dedit("PRINCE", "UB", 11111, 2204, 2134.45f);
            s.Transfer("PRINCE", "UB", 11111, 2204,"RAJA", 22222, 555.21f);//Same Bank
            s.Transfer("PRINCE", "UB", 11111, 2204,"KING","INDB", 0000, 4323.21f);//Differnt Bank

            s.Transaction("PRINCE", "UB", 11111, 2204) ;
            s.Transaction("RAJA", "UB", 22222, 1234) ;
            s.Transaction("KING", "INDB", 0000, 2434);

            s.Balance("PRINCE", "UB", 11111, 2204);
            //s.Credit("Faiz", "INDB", 1212, 14345.54, "I am king"); //Name bank pincode amount
            //s.debit() //Name bank pincode amount error if it goies zero

            //s.TransferWithin()//YourName bank pin amount(check if possible) to the user accountnumber(check it)
            //s.TransferOutside()//Yourname bank pin amount transfer accountnumber bankname


            //Open an new accout for an user

            /*            indianBank.CreateNewAccount(new Person { Name = "Faiz",Amount=123.34f});

                        unionBank.CreateNewAccount(new Person { Name = "Faiz", Amount = 35667.34f });

                        unionBank.CreateNewAccount(new Person { Name = "Akram",Amount=90877.56f});

                        unionBank.CreateNewAccount(new Person { Name = "Faiz Ak",Amount=8444});*/


        }

    }
}






