using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Infrastructure.Data.Models
{
    public class Reservation
    {
        [Key]   
        public int Id { get; set; }

        [Required]  
        public int RoomId { get; set; }
        [Required]
        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; } = null!;

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int GuestId { get; set; }
        [Required]
        [ForeignKey(nameof(GuestId))]
        public Guest Guest { get; set; } = null!;
    }
}