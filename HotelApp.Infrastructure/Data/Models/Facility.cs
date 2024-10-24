using HotelApp.Common.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HotelApp.Common.Constants.ValidationConstants;

namespace HotelApp.Infrastructure.Data.Models
{
    public class Facility
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public FacilityType FacilityType { get; set; }

        [Required]
        [MaxLength(FacilityDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Precision(RequiredPrecision, RequiredScale)]
        public decimal Price { get; set; }

        [Required]
        public DateTime OpenAt { get; set; }

        [Required]
        public DateTime CloseAt { get; set; }

        public IEnumerable<ReservationFacility> ReservationsFacility { get; set; }
            = new List<ReservationFacility>();
    }
}
