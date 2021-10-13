using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Table.Booking.Application.Table.Commands.UpdateBookingTime
{
    public class UpdateBookingTimeCommand : IRequest
    {
        public Guid Id { get; set; }
        public TimeSpan NewBookingTime { get; set; }
    }
}
