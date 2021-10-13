using System;
using System.Collections.Generic;
using System.Text;
using Table.Booking.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Table.Booking.Persistence.EntityTypeConfigurations
{
    public class TableConfiguration : IEntityTypeConfiguration<RestTable>
    {
        public void Configure(EntityTypeBuilder<RestTable> builder)
        {
            builder.HasKey(tbl => tbl.Id);
            builder.HasIndex(tbl => tbl.Id).IsUnique();
            builder.Property(tbl => tbl.PersonCapacity);
            builder.Property(tbl => tbl.IsIndoors);
            builder.Property(tbl => tbl.BookedTimes);
        }
    }
}
