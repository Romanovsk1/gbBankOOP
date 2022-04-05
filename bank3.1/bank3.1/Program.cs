using System;
using System.Collections.Generic;


namespace bank3._1
  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> listAccount = new();

            BankAccount account1 = new BankAccount(1000, BankAccountType.SavingAccount);
            BankAccount account2 = new BankAccount(7547, BankAccountType.BankCardAccount);
            BankAccount account3 = new BankAccount(5435, BankAccountType.AccumulativeAccount);
            BankAccount account4 = new BankAccount(85888, BankAccountType.BankCardAccount);

            listAccount.Add(account1);
            listAccount.Add(account2);
            listAccount.Add(account3);
            listAccount.Add(account4);

            foreach (var item in listAccount)
            {
                item.FullInfo();
            }

            Console.WriteLine();

            string exit;
            do
            {
                Console.WriteLine("Для выхода нажмите Q + Enter. Для выбора текущего счёта нажмите номер счёта");

                exit = Console.ReadLine();
                exit = exit.ToLower();


                int _fromTheAccount = 1;
                bool _isAccountFound = true;
                bool _isTake = true;
                long _take = 0;



                switch (exit)
                {
                    case "1":

                        Console.WriteLine("Выбран текущий счёт № 1.");
                        do
                        {
                            Console.WriteLine("Выберете счёт с которого будут переведены деньги:");

                            try
                            {
                                _fromTheAccount = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in listAccount)
                                {
                                    if (item.Number == _fromTheAccount)
                                    {
                                        _isAccountFound = false;
                                        break;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Не корректный номер счёта");
                            }

                        } while (_isAccountFound);


                        do
                        {
                            Console.WriteLine("Выберете сумму списания денег:");

                            try
                            {
                                _take = Convert.ToInt64(Console.ReadLine());
                                _isTake = false;

                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Некорректная сумма списания!");
                            }

                        } while (_isTake);


                        account1.MoneyTransfer(listAccount[_fromTheAccount - 1], _take);
                        break;


                    case "2":

                        Console.WriteLine("Выбран текущий счёт № 2.");
                        do
                        {
                            Console.WriteLine("Выберете счёт с которого будут переведены деньги:");

                            try
                            {
                                _fromTheAccount = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in listAccount)
                                {
                                    if (item.Number == _fromTheAccount)
                                    {
                                        _isAccountFound = false;
                                        break;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Не корректный номер счёта");
                            }

                        } while (_isAccountFound);


                        do
                        {
                            Console.WriteLine("Выберете сумму списания денег:");

                            try
                            {
                                _take = Convert.ToInt64(Console.ReadLine());
                                _isTake = false;

                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Некорректная сумма списания!");

                            }

                        } while (_isTake);



                        account2.MoneyTransfer(listAccount[_fromTheAccount - 1], _take);
                        break;


                    case "3":

                        Console.WriteLine("Выбран текущий счёт № 3.");
                        do
                        {
                            Console.WriteLine("Выберете счёт с которого будут переведены деньги:");

                            try
                            {
                                _fromTheAccount = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in listAccount)
                                {
                                    if (item.Number == _fromTheAccount)
                                    {
                                        _isAccountFound = false;
                                        break;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Не корректный номер счёта");
                            }

                        } while (_isAccountFound);


                        do
                        {
                            Console.WriteLine("Выберете сумму списания денег:");

                            try
                            {
                                _take = Convert.ToInt64(Console.ReadLine());
                                _isTake = false;

                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Некорректная сумма списания!");

                            }

                        } while (_isTake);


                        account3.MoneyTransfer(listAccount[_fromTheAccount - 1], _take);
                        break;


                    case "4":

                        Console.WriteLine("Выбран текущий счёт № 4.");
                        do
                        {
                            Console.WriteLine("Выберете счёт с которого будут переведены деньги:");

                            try
                            {
                                _fromTheAccount = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in listAccount)
                                {
                                    if (item.Number == _fromTheAccount)
                                    {
                                        _isAccountFound = false;
                                        break;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Не корректный номер счёта");
                            }

                        } while (_isAccountFound);


                        do
                        {
                            Console.WriteLine("Выберете сумму списания денег:");

                            try
                            {
                                _take = Convert.ToInt64(Console.ReadLine());
                                _isTake = false;

                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Некорректная сумма списания!");

                            }

                        } while (_isTake);


                        account4.MoneyTransfer(listAccount[_fromTheAccount - 1], _take);
                        break;

                    default:
                        break;
                }
            } while (exit != "q");
        }
    }
}
