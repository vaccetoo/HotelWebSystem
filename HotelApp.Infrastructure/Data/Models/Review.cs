using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HotelApp.Common.Constants.ValidationConstants;

namespace HotelApp.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ReviewCommentMaxLength)]
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
