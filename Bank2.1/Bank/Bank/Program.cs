using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            
            Random random = new Random();

            bankAccount.AccountNumber(random.Next(1,999999999));
            bankAccount.Balance(999999);
            bankAccount.AccountType(BankAccountType.BankCardAccount);
            bankAccount.FullInfo();
           
          
        }
    }
}
