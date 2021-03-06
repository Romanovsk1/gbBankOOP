using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2._3
{
    internal class BankAccount
    {
        private long _accountNumber;
        private long _balance;
        private BankAccountType _bankAccountType;
        private static long _counter = 1;

        public BankAccount(long balance) 
        {
            _balance = balance;
            _accountNumber = Counter();
        }


        public BankAccount(BankAccountType bankAccountType)
        {
            _bankAccountType = bankAccountType;
            _accountNumber = Counter();
        }

        public BankAccount(long balance, BankAccountType bankAccountType)
        {
            _balance = balance;
            _bankAccountType = bankAccountType;
            _accountNumber = Counter();
        }


        long Counter()
        {
            return _counter++;
        }

        public BankAccount()
        {
            _accountNumber = Counter();
        }
        public long infoAccountNumber()
        {
            return _accountNumber;
        }

        public long infoBalance()
        {
            return _balance;
        }

        public BankAccountType infoAccountType()
        {
            return _bankAccountType;
        }

        public void AccountNumber(long accountNumber)
        {
            _accountNumber = accountNumber;
        }

        public void Balance(long balance)
        {
            _balance = balance;
        }

        public void AccountType(BankAccountType bankAccountType)
        {
            _bankAccountType = bankAccountType;
        }



        public void FullInfo()
        {
            Console.WriteLine($"Тип счёта:{_bankAccountType} , Номер счёта: {_accountNumber}, Баланс: {_balance}");
        }

    }
}
