using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        /// <summary>
        /// Номер счёта
        /// Баланс
        /// Тип
        /// с закрытами полями
        /// </summary>
        private  long _accountNumber;
        private  long _balance;
        private BankAccountType _bankAccountType;

        public  long infoAccountNumber()
        { 
                return _accountNumber;      
        }

        public  long infoBalance()
        {  
                return _balance;
        }

        public BankAccountType infoAccountType ()
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

        public void AccountType (BankAccountType bankAccountType)
        {
            _bankAccountType = bankAccountType;
        }
       

        public void FullInfo()
        {
            Console.WriteLine($"Тип счёта:{_bankAccountType} , Номер счёта: {_accountNumber}, Баланс: {_balance}");
        }



    }
}
