using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Table.Booking.Application.Interfaces;
using Table.Booking.Domain;
using Table.Booking.Persistence.EntityTypeConfigurations;

namespace Table.Booking.Persistence
{
    public class TableBookingDbContext : DbContext, ITableBookingDbContext
    {
        public DbSet<RestTable> Tables { get; set; }

        public DbSet<BookingRecord> BookingRecords { get; set; }

        public TableBookingDbContext(DbContextOptions<TableBookingDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TableConfiguration());
            builder.ApplyConfiguration(new BookingRecordConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
