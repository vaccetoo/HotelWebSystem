using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HotelApp.Common.Constants.ValidationConstants;

namespace HotelApp.Infrastructure.Data.Models
{
    [Comment("Review given from Guest - (Must be an IdentityUser)")]
    public class Review
    {
        [Key]
        [Comment("Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ReviewCommentMaxLength)]
        [Comment("Comment from the User(Guest) about their stay")]
        public string Comment { get; set; } = string.Empty;

        [Required]
        [Comment("The rating from the User(Guest) about their stay")]
        public int Rating { get; set; }

        [Required]
        [Comment("IdentityUser identifier")]
        public string ApplicationUserId { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser ApplicationUser { get; set; } = null!;
    }
}
