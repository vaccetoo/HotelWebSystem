using HotelApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelApp.Infrastructure.Data.Configuration
{
    public class ReservationParticipantConfiguration : IEntityTypeConfiguration<ReservationParticipant>
    {
        public void Configure(EntityTypeBuilder<ReservationParticipant> builder)
        {
            builder
                .HasKey(rp => new
                {
                    rp.ReservationId,
                    rp.GuestId
                });
        }
    }
}
