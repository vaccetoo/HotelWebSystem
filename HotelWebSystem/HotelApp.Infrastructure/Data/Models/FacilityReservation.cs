using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Infrastructure.Data.Models
{
    public class FacilityReservation
    {
        [Required]
        public int FacilityId { get; set; }
        [Required]
        [ForeignKey(nameof(FacilityId))]
        public Facility Facility { get; set; } = null!;

        [Required]
        public int ReservationId { get; set; }
        [Required]
        [ForeignKey(nameof(ReservationId))]
        public Reservation Reservation { get; set; } = null!;
    }
}
