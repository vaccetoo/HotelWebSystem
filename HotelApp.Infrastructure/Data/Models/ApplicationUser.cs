using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        IEnumerable<Reservation> Reservations = new List<Reservation>();

        IEnumerable<Review> Reviews = new List<Review>();
    }
}
