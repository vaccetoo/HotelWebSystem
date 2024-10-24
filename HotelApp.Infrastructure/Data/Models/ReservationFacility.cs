using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Infrastructure.Data.Models
{
    [PrimaryKey(nameof(ReservationId), nameof(Facilityid))]
    [Comment("Shows the relationship between reservation and facility")]
    public class ReservationFacility
    {
        [Required]
        [Comment("Reservation identifier")]
        public int ReservationId { get; set; }
        [Required]
        [ForeignKey(nameof(ReservationId))]
        public Reservation Reservation { get; set; } = null!;


        [Required]
        [Comment("Facility identifier")]
        public int Facilityid { get; set; }
        [Required]
        [ForeignKey(nameof(Facilityid))]
        public Facility Facility { get; set; } = null!;
    }
}
