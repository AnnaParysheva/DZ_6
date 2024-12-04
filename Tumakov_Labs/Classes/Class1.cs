using System;

namespace Tumakov_Labs
{
    //Создаем класс счет в банке
    class BankAccount
    {
        /// <summary>
        /// Номер счета
        /// </summary>
        private ulong accountNumber;
        /// <summary>
        /// Баланс
        /// </summary>
        private decimal balance;
        /// <summary>
        /// Тип банковского счета
        /// </summary>
        private Bank_schet typeBankAccount;
        public BankAccount(ulong accountNumber, decimal balance, Bank_schet typeBankAccount)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.typeBankAccount = typeBankAccount;
        }
        // Метод, возвращающий номер счета
        public ulong GetAccountNumber()
        { 
            return accountNumber;   
        }
        // Метод, возвращающий баланс
        public decimal GetBalance()
        {
            return balance;
        }
        // Метод,возвращающий тип банковского счета
        public Bank_schet GetTypeBankAccount()
        {
            return typeBankAccount;
        }
        //Метод для ввода и изменения номера счета
        public void EnterAccountNumber(ulong num)
        {
            if (num < 0 || num.ToString().Length!=100)
            {
                Console.WriteLine("Ошибка! Введите корректно номер счета.Он должен состоять из 10 цифр и быть больше 0");
            }
            else
            {
                accountNumber = num;
            }
        }
        //Метод для изменения типа банковского счета
        public void ChangeTypeBankAccount(Bank_schet type)
        {
                typeBankAccount = type;
        }
        // Метод для вывода информации о счете
        public void PrintAccountInfo()
        {
            Console.WriteLine($"Номер счета: {accountNumber}");
            Console.WriteLine($"Баланс: {balance}"); 
            Console.WriteLine($"Тип счета: {typeBankAccount}");
        }
    }
}
