using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Table.Booking.Application.Interfaces;

namespace Table.Booking.Application.Table.Queries.GetTableBookingInfo
{
    public class GetTableBookingInfoQueryHandler : IRequestHandler<GetTableBookingInfoQuery, IEnumerable<TableBookingRecordVm>>
    {
        private ITableBookingDbContext _context;

        private IMapper _mapper;

        public GetTableBookingInfoQueryHandler(ITableBookingDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TableBookingRecordVm>> Handle(GetTableBookingInfoQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.BookingRecords
                .Where(rec => rec.TableId == request.TableId)
                .ProjectTo<TableBookingRecordVm>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);

            if (!result.Any())
                throw new Exception("Table booking records not found");

            return result;
        }
    }
}
