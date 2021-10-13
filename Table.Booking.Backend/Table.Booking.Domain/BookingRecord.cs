using System;
using System.Collections.Generic;
using System.Text;

namespace Table.Booking.Domain
{
    public class BookingRecord
    {
        public Guid Id { get; set; }

        public Guid TableId { get; set; }

        public string BookerName { get; set; }

        public TimeSpan BookedTime { get; set; }
    }
}
