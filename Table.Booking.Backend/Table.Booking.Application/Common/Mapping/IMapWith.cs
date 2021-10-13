using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Table.Booking.Application.Common.Mapping
{
    public interface IMapWith<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
