using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Infrastructure.Data.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }

        [Required]
        public string ApplicationUserId { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        public int RoomId { get; set; }
        [Required]
        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; } = null!;

        public IEnumerable<ReservationParticipant> ReservationParticipants { get; set; } 
            = new List<ReservationParticipant>();

        public IEnumerable<ReservationFacility> ReservationFacilities { get; set; } 
            = new List<ReservationFacility>();
    }
}
