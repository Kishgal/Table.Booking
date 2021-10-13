using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Table.Booking.Application.Common.Mapping;
using Table.Booking.Domain;

namespace Table.Booking.Application.Table.Queries.GetTableBookingInfo
{
    public class TableBookingRecordVm : IMapWith<BookingRecord>
    {
        public Guid Id { get; set; }

        public Guid TableId { get; set; }

        public string BookerName { get; set; }

        public DateTime BookedTime { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BookingRecord, TableBookingRecordVm>()
                .ForMember(recvm => recvm.BookerName, opt => opt.MapFrom(rec => rec.BookerName))
                .ForMember(recvm => recvm.BookedTime, opt => opt.MapFrom(rec => rec.BookedTime))
                .ForMember(recvm => recvm.Id, opt => opt.MapFrom(rec => rec.Id))
                .ForMember(recvm => recvm.TableId, opt => opt.MapFrom(rec => rec.TableId))
                ;
        }
    }
}
