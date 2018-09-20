using System;

namespace WorkWithLinqQuery.Models
{
    public class ReservationItem
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int BookNumber { get; set; }
    }
}