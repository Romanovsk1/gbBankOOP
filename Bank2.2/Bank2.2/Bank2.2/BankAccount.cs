using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2._2
{
    internal class BankAccount


    {/// <summary>
     /// Номер счёта
     /// Баланс
     /// с закрытами полями
     /// </summary>
        private long _accountNumber;
        private long _balance;
        private BankAccountType _bankAccountType;
        private static int _counter = 1;

        public int Counter()
        {
            
            return _counter++; 
        }

        public long AccountNumber()
        {
            _accountNumber = _counter;
            return _accountNumber;
        }

        public long Balance(long balance)
        {

            _balance = balance;
            return _balance;
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
