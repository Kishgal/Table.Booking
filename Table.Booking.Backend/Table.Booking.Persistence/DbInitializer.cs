using System;
using System.Collections.Generic;
using System.Text;

namespace Table.Booking.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(TableBookingDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
