using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Table.Booking.Application.Table.Queries.GetTableBookingInfo
{
    public class GetTableBookingInfoQuery : IRequest<IEnumerable<TableBookingRecordVm>>
    {
        public Guid TableId { get; set; }
    }
}
