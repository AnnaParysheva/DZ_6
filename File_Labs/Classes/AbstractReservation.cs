using System;

namespace File_Labs
{
    // Абстрактный класс (бронирование столиков)
    public abstract class Reservation
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public ulong PhoneNumber {  get; set; }
        /// <summary>
        /// Дата бронированя
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Количество людей
        /// </summary>
        public int NumberOfPeople { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public string Status { get; protected set; }
        protected Reservation(string name,ulong phoneNumber, DateTime date, int numberOfPeople) 
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Date = date;
            NumberOfPeople = numberOfPeople;
            Status=" ";
        }
        /// <summary>
        /// Подтверждение бронирования
        /// </summary>
        public abstract void ConfirmReservation();
        /// <summary>
        /// Отмена бронирования
        /// </summary>
        public abstract void CancelReservation();
        /// <summary>
        /// Изменение даты бронирования
        /// </summary>
        /// <param name="newDate"></param>
        public abstract void ChangeReservationDate(DateTime newDate);
        /// <summary>
        /// Вывести детали бронирования
        /// </summary>
        public abstract void DisplayReservationDetails();
    }
}
