using HotelBookingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data
{
    public class APIContext : DbContext
    {
        public DbSet<HotelBooking> Bookings { get; set; }

        public APIContext(DbContextOptions<APIContext> options)
            : base(options)
        {

        }
    }
}
