using HotelApp.Common.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HotelApp.Common.Constants.ValidationConstants;

namespace HotelApp.Infrastructure.Data.Models
{
    [Comment("Room in the Hotel")]
    public class Room
    {
        [Key]
        [Comment("Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Type of the room")]
        public RoomType RoomType { get; set; }

        [Required]
        [Precision(RequiredPrecision, RequiredScale)]
        [Comment("Room price for one night")]
        public decimal PricePerNight { get; set; }

        public IEnumerable<Reservation> Reservations { get; set; } 
            = new List<Reservation>();
    }
}
