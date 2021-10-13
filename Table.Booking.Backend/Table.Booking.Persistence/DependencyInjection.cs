using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Table.Booking.Application.Interfaces;

namespace Table.Booking.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<TableBookingDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });

            services.AddScoped<ITableBookingDbContext>(provider => provider.GetService<TableBookingDbContext>());

            return services;
        }
    }
}
