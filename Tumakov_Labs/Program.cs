using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Labs
{
    //Виды банковского счета
    enum Bank_schet
    {
        Current,
        Saving
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Task7_1();
            Task7_2();
            Task7_3();
            TaskDZ_7_1();
            Console.ReadKey();
        }
        static void Task7_1()
        {
            Console.WriteLine("\nУпражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип из упр. 3.1). Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.");
            BankAccount myAccount = new BankAccount(1234567890, 100000.00m, Bank_schet.Saving);
            myAccount.PrintAccountInfo();
            myAccount.ChangeTypeBankAccount(Bank_schet.Current);
            Console.WriteLine("\nПосле изменения типа банковского счета и пополнения:");
            myAccount.PrintAccountInfo();
        }
        static void Task7_2()
        {
            Console.WriteLine("\nУпражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы номер счета генерировался сам и был уникальным. Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.");
            BankAccount72 myAccount72 = new BankAccount72(100000.00m, Bank_schet.Saving);
            myAccount72.PrintAccountInfo72();
            myAccount72.ChangeTypeBankAccount72(Bank_schet.Current);
            Console.WriteLine("\nПосле изменения типа банковского счета и пополнения:");
            myAccount72.PrintAccountInfo72();
        }
        static void Task7_3()
        {
            Console.WriteLine("\nУпражнение 7.3 Добавить в класс счет в банке два метода: снять со счета и положить на счет. Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.");
            BankAccount73 myAccount73 = new BankAccount73(100000.00m, Bank_schet.Saving);
            myAccount73.PrintAccountInfo73();
            myAccount73.AccountReplenishment73(5000.00m);
            Console.WriteLine("\nПосле изменения типа банковского счета и пополнения:");
            myAccount73.PrintAccountInfo73();
        }
        static void TaskDZ_7_1()
        {
            Console.WriteLine("\nДомашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов). Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати. Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания, и предусмотреть метод, который увеличивал бы значение этого поля.");
            Building building = new Building(15, 6, 90, 3);
            building.PrintBuildingInfo();
        }
    }
}
