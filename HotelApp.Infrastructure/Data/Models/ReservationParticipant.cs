using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Infrastructure.Data.Models
{
    [PrimaryKey(nameof(GuestId), nameof(ReservationId))]
    [Comment("Shows relationships between reservation and guest")]
    public class ReservationParticipant
    {
        [Required]
        [Comment("Guest identifier")]
        public int GuestId { get; set; }
        [Required]
        [ForeignKey(nameof(GuestId))]
        public Guest Guest { get; set; } = null!;


        [Required]
        [Comment("Reservation identifier")]
        public int ReservationId { get; set; }
        [Required]
        [ForeignKey(nameof(ReservationId))]
        public Reservation Reservation { get; set; } = null!;
    }
}
