using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HotelApp.Common.Constants.ValidationConstants;

namespace HotelApp.Infrastructure.Data.Models
{
    [Comment("Reservation in the Hotel")]
    public class Reservation
    {
        [Key]
        [Comment("Identifier")]
        public int Id { get; set; }

        [Required]
        [Precision(RequiredPrecision, RequiredScale)]
        [Comment("Shows the total price after any additional facilities, if there is any")]
        public decimal TotalPrice { get; set; }

        [Required]
        [Comment("Reservation start day")]
        public DateTime DateStart { get; set; }

        [Required]
        [Comment("Reservation end date")]
        public DateTime DateEnd { get; set; }

        [Required]
        [Comment("Identity user identifier")]
        public string ApplicationUserId { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        [Comment("Room identifier")]
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
