using System;

namespace Tumakov_Labs
{
    //Создаем класс счет в банке
    class BankAccount73
    {
        /// <summary>
        /// Статическая переменная для хранения последнего сгенерированного номера счета
        /// </summary>
        private static ulong lastAccountNumber73 = 1234567890;
        /// <summary>
        /// Номер счета
        /// </summary>
        private ulong accountNumber73;
        /// <summary>
        /// Баланс
        /// </summary>
        private decimal balance73;
        /// <summary>
        /// Тип банковского счета
        /// </summary>
        private Bank_schet typeBankAccount73;
        public BankAccount73(decimal balance73, Bank_schet typeBankAccount73)
        {
            this.accountNumber73 = GenerateUniqueAccountNumber73();
            this.balance73 = balance73;
            this.typeBankAccount73 = typeBankAccount73;
        }
        // Метод для генерации уникального номера счета
        private static ulong GenerateUniqueAccountNumber73()
        {
            return lastAccountNumber73++;
        }
        // Метод, возвращающий баланс
        public decimal GetBalance73()
        {
            return balance73;
        }
        // Метод,возвращающий тип банковского счета
        public Bank_schet GetTypeBankAccount73()
        {
            return typeBankAccount73;
        }
        //Метод для изменения типа банковского счета
        public void ChangeTypeBankAccount73(Bank_schet type)
        {
            typeBankAccount73 = type;
        }
        //Метод для пополнения счета
        public void AccountReplenishment73(decimal sum)
        {
            if (sum < 0)
            {
                Console.WriteLine("Сумма пополнения должна быть больше 0");
            }
            else
            {
                balance73 += sum;
            }
        }
        //Метод для снятия со счета
        public void AccountWithdrawal(decimal sum)
        {
            if (balance73-sum < 0)
            {
                Console.WriteLine("Невозможно снять такую сумму!");
            }
            else
            {
                balance73 -= sum;
            }
        }
        // Метод для вывода информации о счете
        public void PrintAccountInfo73()
        {
            Console.WriteLine($"Номер счета: {accountNumber73}");
            Console.WriteLine($"Баланс: {balance73}");
            Console.WriteLine($"Тип счета: {typeBankAccount73}");
        }
    }
}
