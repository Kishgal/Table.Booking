using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Table.Booking.Domain;

namespace Table.Booking.Persistence.EntityTypeConfigurations
{
    public class BookingRecordConfiguration : IEntityTypeConfiguration<BookingRecord>
    {
        public void Configure(EntityTypeBuilder<BookingRecord> builder)
        {
            builder.HasKey(record => record.Id);
            builder.HasIndex(record => record.Id).IsUnique();
            builder.HasIndex(record => record.TableId);
            builder.Property(record => record.BookerName);
            builder.Property(record => record.BookedTime);
        }
    }
}
