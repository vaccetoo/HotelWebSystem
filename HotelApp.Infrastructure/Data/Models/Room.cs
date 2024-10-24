using HotelApp.Common.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HotelApp.Common.Constants.ValidationConstants;

namespace HotelApp.Infrastructure.Data.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public RoomType RoomType { get; set; }

        [Required]
        [Precision(RequiredPrecision, RequiredScale)]
        public decimal PricePerNight { get; set; }

        public IEnumerable<Reservation> Reservations { get; set; } 
            = new List<Reservation>();
    }
}
