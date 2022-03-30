using System;

namespace Bank2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount();
            BankAccount bankAccount3 = new BankAccount();

            Random random = new Random();

            bankAccount1.AccountNumber();
            bankAccount1.Balance(999999);
            bankAccount1.AccountType(BankAccountType.BankCardAccount);
            bankAccount1.FullInfo();
            bankAccount2.FullInfo();
            bankAccount3.FullInfo();
        }
    }
}
