using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Infrastructure.Data.Models
{
    [PrimaryKey(nameof(ReservationId), nameof(Facilityid))]
    public class ReservationFacility
    {
        [Required] 
        public int ReservationId { get; set; }
        [Required]
        [ForeignKey(nameof(ReservationId))]
        public Reservation Reservation { get; set; } = null!;


        [Required]
        public int Facilityid { get; set; }
        [Required]
        [ForeignKey(nameof(Facilityid))]
        public Facility Facility { get; set; } = null!;
    }
}
