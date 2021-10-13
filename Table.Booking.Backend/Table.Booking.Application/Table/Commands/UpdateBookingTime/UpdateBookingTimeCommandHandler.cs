using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Table.Booking.Application.Interfaces;
using Table.Booking.Application.Table.Commands.BookTable;
using Table.Booking.Domain;

namespace Table.Booking.Application.Table.Commands.UpdateBookingTime
{
    public class UpdateBookingTimeCommandHandler : IRequestHandler<UpdateBookingTimeCommand>
    {
        private ITableBookingDbContext _context;

        public UpdateBookingTimeCommandHandler(ITableBookingDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateBookingTimeCommand request, CancellationToken cancellationToken)
        {
            var record = await _context.BookingRecords.FirstOrDefaultAsync(rec => rec.Id == request.Id, cancellationToken);

            if (record == null)
                throw new Exception("Booking record not found");

            record.BookedTime = request.NewBookingTime;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
