using System.ComponentModel.DataAnnotations;
using HotelApp.Common.Enum;
using Microsoft.EntityFrameworkCore;
using static HotelApp.Common.Constants.ValidationConstants;

namespace HotelApp.Infrastructure.Data.Models
{
    public class Facility
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public FacilityType Type { get; set; }

        [Required]
        [MaxLength(FacilityDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), nameof(FacilityMinPrice), nameof(FacilityMaxPrice))]
        [Precision(DecimalPrecision,DecimalScale)]
        public decimal Price { get; set; }

        [Required]
        public DateTime OpenAt { get; set; }

        [Required]
        public DateTime CloseAt { get; set; }

        public IEnumerable<FacilityReservation> FacilityReservations { get; set; } = new List<FacilityReservation>();
    }
}