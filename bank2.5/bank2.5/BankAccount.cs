using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank2._5
{
    internal class BankAccount
    {
        
        private long _accountNumber;
        private long _balance;
        private BankAccountType _bankAccountType;
        private static long _counter = 1;


        public long Number
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                if (value.GetType().ToString() == "System.Int32")
                {
                    _accountNumber = value;
                }
            }

        }


        

        public long Balance1
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value.GetType().ToString() == "System.Decimal")
                {
                    _balance = value;
                }
            }

        }

        

        public BankAccountType TypeAccount
        {
            get
            {
                return _bankAccountType;
            }
            set
            {
                if (value.GetType().ToString() == "GB_04_02BankAccount04.TypeOfBankAccount")
                {
                    _bankAccountType = value;
                }
            }
        }

        //Пополнить счёт
        public void DepositMoney(long number, long refill)
        {
            if (number == _accountNumber)
            {
                _balance = _balance + refill;
                Console.WriteLine($"Счёт пополнен на: {refill}");

            }

        }

        
        // Снять со счета
        
        public void WithdrawMoney(long number, long take)
        {
            if (number == _accountNumber)
            {
                if (_balance >= take)
                {
                    _balance = _balance - take;

                    Console.WriteLine($"Со счёта снята на: {take}");
                }
                else
                    Console.WriteLine($"На счету недостаточно средств. Баланс: {_balance}; Сумма для снятия: {take};");

            }
        }

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
