using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HotelApp.Common.Constants.ValidationConstants;

namespace HotelApp.Infrastructure.Data.Models
{
    [Comment("Guest in the Hotel - (Does not need to be IdentityUser)")]
    public class Guest
    {
        [Key]
        [Comment("Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(GuestFullNameMaxLength)]
        [Comment("Guest full name")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [RegularExpression(PhoneNumberPattern)]
        [Comment("Guest phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [RegularExpression(EmailAddressPattern)]
        [Comment("Guest email address")]
        public string EmailAddress { get; set; } = string.Empty;

        public IEnumerable<ReservationParticipant> ReservationsParticipant { get; set; } 
            = new List<ReservationParticipant>();
    }
}
