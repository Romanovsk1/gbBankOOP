using System;

namespace Bank2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount(10,BankAccountType.BankCardAccount);
            BankAccount bankAccount2 = new BankAccount(1000000000);
            BankAccount bankAccount3 = new BankAccount(BankAccountType.SavingsAccount);

            bankAccount1.FullInfo();
            bankAccount2.FullInfo();
            bankAccount3.FullInfo();

        }
    }
}
