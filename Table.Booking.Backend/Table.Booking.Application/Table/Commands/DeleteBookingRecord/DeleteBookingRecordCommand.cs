using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Table.Booking.Application.Table.Commands.DeleteBookingRecord
{
    public class DeleteBookingRecordCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
