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
        public int GuestId { get; set; }
        [Required]
        [ForeignKey(nameof(GuestId))]
        public Guest Guest { get; set; } = null!;

        [Required]
        [Range(ReviewMinRaiting, ReviewMaxRaiting)]
        public int Raiting { get; set; }

        [Required]
        [MaxLength(ReviewCommentMaxLength)]
        public string Comment { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }
    }
}