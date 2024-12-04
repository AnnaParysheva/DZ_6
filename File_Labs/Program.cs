using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TableReservation tableRes = new TableReservation("Анна", 89999999999, DateTime.Now.AddDays(1), 2, 12);
            PartyReservation partyRes = new PartyReservation("Анна", 89999999999, DateTime.Now.AddDays(2), 10, 5, "Евгения");
            tableRes.ConfirmReservation();
            partyRes.ConfirmReservation();
            tableRes.DisplayReservationDetails();
            partyRes.DisplayReservationDetails();
            tableRes.ChangeReservationDate(DateTime.Now.AddDays(3));
            partyRes.ChangeReservationDate(DateTime.Now.AddDays(4));
            tableRes.DisplayReservationDetails();
            partyRes.DisplayReservationDetails();
            tableRes.CancelReservation();
            partyRes.CancelReservation();
            tableRes.DisplayReservationDetails();
            partyRes.DisplayReservationDetails();
            Console.ReadKey();
        }
    }
}
