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
        public int RoomNumber { get; set; }

        [Required]
        [Range(RoomMinCapacity, RoomMaxCapacity)]
        public int Capacity { get; set; }

        [Required]
        [Range(typeof(decimal), nameof(RoomMinPrice), nameof(RoomMaxPrice))]
        [Precision(DecimalPrecision, DecimalScale)]
        public decimal PricePerNight { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        public IEnumerable<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}