using System;

namespace Tumakov_Labs
{
    //Создаем класс счет в банке
    class BankAccount72
    {
        /// <summary>
        /// Статическая переменная для хранения последнего сгенерированного номера счета
        /// </summary>
        private static ulong lastAccountNumber = 1234567891; 
        /// <summary>
        /// Номер счета
        /// </summary>
        private ulong accountNumber72;
        /// <summary>
        /// Баланс
        /// </summary>
        private decimal balance72;
        /// <summary>
        /// Тип банковского счета
        /// </summary>
        private Bank_schet typeBankAccount72;
        public BankAccount72(decimal balance72, Bank_schet typeBankAccount72)
        {
            this.accountNumber72 = GenerateUniqueAccountNumber();
            this.balance72 = balance72;
            this.typeBankAccount72 = typeBankAccount72;
        }
        // Метод для генерации уникального номера счета
        private static ulong GenerateUniqueAccountNumber()
        {
            return lastAccountNumber++;
        }
        // Метод, возвращающий баланс
        public decimal GetBalance72()
        {
            return balance72;
        }
        // Метод,возвращающий тип банковского счета
        public Bank_schet GetTypeBankAccount72()
        {
            return typeBankAccount72;
        }
        //Метод для изменения типа банковского счета
        public void ChangeTypeBankAccount72(Bank_schet type)
        {
            typeBankAccount72 = type;
        }
        // Метод для вывода информации о счете
        public void PrintAccountInfo72()
        {
            Console.WriteLine($"Номер счета: {accountNumber72}");
            Console.WriteLine($"Баланс: {balance72}");
            Console.WriteLine($"Тип счета: {typeBankAccount72}");
        }
    }
}

