using System.ComponentModel.DataAnnotations;
using static HotelApp.Common.Constants.ValidationConstants;

namespace HotelApp.Infrastructure.Data.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GuestFullNameMaxLength)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [RegularExpression(PhoneNumberPattern)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [RegularExpression(EmailAddressPattern)]
        public string EmailAddress { get; set; } = string.Empty;

        public IEnumerable<ReservationParticipant> ReservationsParticipant { get; set; } 
            = new List<ReservationParticipant>();
    }
}
