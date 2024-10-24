using HotelApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Reservation> Reservations { get; set; } = null!;
        public DbSet<Guest> Guests { get; set; } = null!;
        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<Facility> Facilities { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<ReservationParticipant> ReservationsParticipants { get; set; } = null!;
        public DbSet<ReservationFacility> ReservationsFacilities { get; set; } = null!;
    }
}
