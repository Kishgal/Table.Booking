using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Table.Booking.Application.Interfaces;
using Table.Booking.Domain;

namespace Table.Booking.Application.Table.Commands.BookTable
{
    public class BookTableCommandHandler : IRequestHandler<BookTableCommand, Guid>
    {
        private ITableBookingDbContext _context;

        public BookTableCommandHandler(ITableBookingDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(BookTableCommand request, CancellationToken cancellationToken)
        {
            var recordId = Guid.NewGuid();

            var record = new BookingRecord()
            {
                Id = recordId,
                TableId = request.TableId,
                BookerName = request.GuestName,
                BookedTime = request.BookingTime
            };

            await _context.BookingRecords.AddAsync(record, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return recordId;
        }
    }
}
