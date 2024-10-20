using HotelApp.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.Infrastructure.Data.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public RoomType RoomType { get; set; }

        [Required]
        public decimal PricePerNight { get; set; }

        public IEnumerable<Reservation> Reservations { get; set; } 
            = new List<Reservation>();
    }
}
