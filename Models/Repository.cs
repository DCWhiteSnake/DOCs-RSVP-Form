using System.Collections.Generic;

namespace DOCs_RSVP_Form.Models
{
    public static class Repository
    {
        private static List<Reservation> reservations =
            new List<Reservation>();

        public static IEnumerable<Reservation> Reservations
        {
            get
            {
                return reservations;
            }
        }

        public static void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }
    }
}