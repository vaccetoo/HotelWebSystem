﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Infrastructure.Data.Models
{
    public class ReservationParticipant
    {
        [Required]
        public int ReservationId { get; set; }
        [Required]
        [ForeignKey(nameof(ReservationId))]
        public Reservation Reservation { get; set; } = null!;

        [Required]
        public int GuestId { get; set; }
        [Required]
        [ForeignKey(nameof(GuestId))]
        public Guest Guest { get; set; } = null!;
    }
}
