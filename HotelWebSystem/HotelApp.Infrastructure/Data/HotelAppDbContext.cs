using HotelApp.Infrastructure.Data.Extensions;
using HotelApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Infrastructure.Data
{
    public class HotelAppDbContext : IdentityDbContext<ApplicationUser>
    {
        public HotelAppDbContext(DbContextOptions<HotelAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<FacilityReservation> FacilitiesReservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReservationParticipant> ReservationsParticipants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurations();

            base.OnModelCreating(builder);
        }
    }
}
