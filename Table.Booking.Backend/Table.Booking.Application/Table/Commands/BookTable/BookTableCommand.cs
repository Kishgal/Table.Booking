using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Table.Booking.Application.Table.Commands.BookTable
{
    public class BookTableCommand : IRequest<Guid>
    {
        public string GuestName { get; set; }
        public Guid TableId { get; set; }
        public TimeSpan BookingTime { get; set; }
    }
}
