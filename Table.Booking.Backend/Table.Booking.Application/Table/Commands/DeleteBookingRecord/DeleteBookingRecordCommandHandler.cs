using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Table.Booking.Application.Interfaces;

namespace Table.Booking.Application.Table.Commands.DeleteBookingRecord
{
    public class DeleteBookingRecordCommandHandler : IRequestHandler<DeleteBookingRecordCommand>
    {
        private ITableBookingDbContext _context;

        public DeleteBookingRecordCommandHandler(ITableBookingDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteBookingRecordCommand request, CancellationToken cancellationToken)
        {
            var record = await _context.BookingRecords.FirstOrDefaultAsync(rec => rec.Id == request.Id, cancellationToken);

            if (record == null)
                throw new Exception("Booking record not found");

            _context.BookingRecords.Remove(record);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
