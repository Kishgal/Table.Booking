using System;
using System.Collections.Generic;
using System.Text;

namespace Table.Booking.Domain
{
    public class RestTable
    {
        public Guid Id { get; set; }

        public int PersonCapacity { get; set; }

        public int IsIndoors { get; set; }

        public List<TimeSpan> BookedTimes { get; set; }
    }
}
