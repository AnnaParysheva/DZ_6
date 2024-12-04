using System;

namespace File_Labs
{
    public class TableReservation: Reservation
    {
        /// <summary>
        /// Номер стола
        /// </summary>
        public int TableNumber {  get; set; }
        public TableReservation(string name, ulong phoneNumber, DateTime date, int numberOfPeople, int tableNumber):base(name, phoneNumber, date, numberOfPeople)
        {
            TableNumber=tableNumber;
        }
        // Подтверждение бронирования
        public override void ConfirmReservation()
        {
            Status = "Забронирован";
            Console.WriteLine($"Стол забронирован на имя {Name}, номер стола {TableNumber}.");
        }
        // Отменить бронирование
        public override void CancelReservation()
        {
            Status = "Свободен";
            Console.WriteLine($"Бронирование столика на имя {Name} отменено.");
        }
        // Изменить дату
        public override void ChangeReservationDate(DateTime newDate)
        {
            Date = newDate;
            Console.WriteLine($"Новая дата бронирования: {newDate.ToShortDateString()}.");
        }
        // Вывести детали бронирования
        public override void DisplayReservationDetails()
        {
            Console.WriteLine($"Бронирование столика:\nимя: {Name}, номер телефона: {PhoneNumber}, дата: {Date.ToShortDateString()}, количество людей: {NumberOfPeople}, номер стола: {TableNumber}, статус: {Status}");
        }
    }
}
