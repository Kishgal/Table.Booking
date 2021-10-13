using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Table.Booking.Domain;

namespace Table.Booking.Application.Interfaces
{
    public interface ITableBookingDbContext
    {
        DbSet<RestTable> Tables { get; set; }
        DbSet<BookingRecord> BookingRecords { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellation);
    }
}
