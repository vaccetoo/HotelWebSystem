using System.ComponentModel.DataAnnotations;

namespace HotelApp.Infrastructure.Data.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string EmailAddress { get; set; } = string.Empty;

        public IEnumerable<ReservationParticipant> ReservationsParticipant { get; set; } 
            = new List<ReservationParticipant>();
    }
}
