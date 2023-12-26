namespace SYSv1
{
    interface IBank

    {
        string BankName { get; }

        float CheckBalance(int account);
        Person CheckUser(string recevierName, int recevierAccountNumber);
        void CreateNewAccount(Person person);
        void CreditAmount(string Name, int AccountNumber,
                                int AccountPin, float Amount);
        void DebitAmount(string Name, int AccountNumber,int AccountPin, float Amount);
        //void CheckBalance(int AccountNumber,int AccountPin);
        void PrintPassBook(string Name, int AccountNumber,int AccountPin);

        void TransferOutside(string senderName, int senderAccountNumber, int senderAccountPin, string recevierName, IBank bank, int recevierAccountNumber, float amount);
        void TransferWithin(string senderName, int senderAccountNumber, int senderAccountPin, int recevierAccountNumber, float amount);

        



        //void TransferWithin(IBank destination ,decimal amount);
        //void TransferOutside(string BankName,IBank destination, decimal amount);
    }


    





}






