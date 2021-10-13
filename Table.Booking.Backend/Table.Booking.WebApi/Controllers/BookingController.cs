using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Table.Booking.Application.Table.Commands.BookTable;
using Table.Booking.Application.Table.Commands.DeleteBookingRecord;
using Table.Booking.Application.Table.Commands.UpdateBookingTime;
using Table.Booking.Application.Table.Queries.GetTableBookingInfo;

namespace Table.Booking.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BookingController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TableBookingRecordVm>>> GetTableBookingRecords(GetTableBookingInfoQuery query)
        {
            var res = await Mediator.Send(query);

            return Ok(res);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> BookTable([FromBody] BookTableCommand query)
        {
            var res = await Mediator.Send(query);

            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBookingTime([FromBody] UpdateBookingTimeCommand query)
        {
            var res = await Mediator.Send(query);

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBookingRecord([FromBody] DeleteBookingRecordCommand query)
        {
            var res = await Mediator.Send(query);

            return NoContent();
        }
    }
}
