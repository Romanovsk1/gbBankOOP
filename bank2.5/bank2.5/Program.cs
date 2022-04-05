using System;
using System.Collections.Generic;

namespace bank2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> listAccount = new List<BankAccount>();

            BankAccount account1 = new BankAccount();

            account1.Balance1 = 10;
            account1.Number = 5500;
            account1.TypeAccount = BankAccountType.AccumulativeAccount;

            listAccount.Add(account1);

            Console.WriteLine(account1.Balance1);
            Console.WriteLine(account1.Number);
            Console.WriteLine(account1.TypeAccount);

            BankAccount account2 = new BankAccount(BankAccountType.AccumulativeAccount);
            listAccount.Add(account2);
            BankAccount account3 = new BankAccount(100, BankAccountType.AccumulativeAccount);
            listAccount.Add(account3);

            foreach (var item in listAccount)
            {
                item.FullInfo();
            }

            account1.DepositMoney(account1.Number, 325);
            account1.FullInfo();

            account1.WithdrawMoney(account1.Number, 99);
            account1.FullInfo();

            account1.WithdrawMoney(account1.Number, 455);
            account1.FullInfo();

        }
    }
}
