using System;
using System.Collections.Generic;

namespace File_Labs
{
    public class PartyReservation : Reservation
    {
        /// <summary>
        /// Имя именинника
        /// </summary>
        public string EventName { get; set; }
        public PartyReservation(string name, ulong phoneNumber, DateTime date, int numberOfPeople,int tableNumber, string eventName) : base(name, phoneNumber, date, numberOfPeople)
        {
            EventName = eventName;
        }
        /// <summary>
        /// Подтверждение бронирования
        /// </summary>
        public override void ConfirmReservation()
        {
            Status = "Забронирован";
            Console.WriteLine($"Забронирован стол для празднования дня рождения на имя {Name}. Имя именинника: {EventName}");
        }
        /// <summary>
        /// Отмена бронирования
        /// </summary>
        public override void CancelReservation()
        {
            Status = "Свободен";
            Console.WriteLine($"Бронирование праздничного столика на имя {Name} отменено.");
        }
        /// <summary>
        /// Изменить дату бронирования
        /// </summary>
        /// <param name="newDate"></param>
        public override void ChangeReservationDate(DateTime newDate)
        {
            Date = newDate;
            Console.WriteLine($"Новая дата бронирования: {newDate.ToShortDateString()}.");
        }
        /// <summary>
        /// Вывести детали бронирования
        /// </summary>
        public override void DisplayReservationDetails()
        {
            Console.WriteLine($"Бронирование праздничного стола:\nимя, на которое забронирован столик: {Name}, имя именинника: {EventName}, дата: {Date.ToShortDateString()}, количество людей: {NumberOfPeople}, статус: {Status}");
        }
    }

}
