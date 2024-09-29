using System.ComponentModel.DataAnnotations;
using static HotelApp.Common.Constants.ValidationConstants;

namespace HotelApp.Infrastructure.Data.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [RegularExpression(PhoneNumberPattern)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [RegularExpression(EmailPattern)]
        public string Email { get; set; } = null!;

        public IEnumerable<Reservation> Reservations { get; set; } = new List<Reservation>();
        public IEnumerable<Review> Reviews { get; set; } = new List<Review>();
    }
}