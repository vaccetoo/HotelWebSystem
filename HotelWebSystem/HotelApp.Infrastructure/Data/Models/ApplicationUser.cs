using Microsoft.AspNetCore.Identity;

namespace HotelApp.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public IEnumerable<Review> Reviews { get; set; } = new List<Review>();

        public IEnumerable<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
