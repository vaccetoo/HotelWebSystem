using HotelApp.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.Infrastructure.Data.Models
{
    public class Facility
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public FacilityType FacilityType { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime OpenAt { get; set; }

        [Required]
        public DateTime CloseAt { get; set; }

        public IEnumerable<ReservationFacility> ReservationsFacility { get; set; }
            = new List<ReservationFacility>();
    }
}
