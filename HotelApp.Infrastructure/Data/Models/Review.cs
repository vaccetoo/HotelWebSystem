using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Comment { get; set; } = string.Empty;

        [Required]
        public int Rating { get; set; }

        [Required]
        public string ApplicationUserId { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser ApplicationUser { get; set; } = null!;
    }
}
