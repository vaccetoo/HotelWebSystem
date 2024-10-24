using HotelApp.Common.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HotelApp.Common.Constants.ValidationConstants;

namespace HotelApp.Infrastructure.Data.Models
{
    [Comment("Facility in the hotel")]
    public class Facility
    {
        [Key]
        [Comment("Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Type of the facility")]
        public FacilityType FacilityType { get; set; }

        [Required]
        [MaxLength(FacilityDescriptionMaxLength)]
        [Comment("Description of the facility")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Precision(RequiredPrecision, RequiredScale)]
        [Comment("Price of the facility")]
        public decimal Price { get; set; }

        [Required]
        [Comment("The time current facility will be open at")]
        public DateTime OpenAt { get; set; }

        [Required]
        [Comment("The time current facility will be closed at")]
        public DateTime CloseAt { get; set; }

        public IEnumerable<ReservationFacility> ReservationsFacility { get; set; }
            = new List<ReservationFacility>();
    }
}
