using HotelApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelApp.Infrastructure.Data.Configuration
{
    public class FacilityReservationConfiguration : IEntityTypeConfiguration<FacilityReservation>
    {
        public void Configure(EntityTypeBuilder<FacilityReservation> builder)
        {
            builder
                .HasKey(fr => new
                {
                    fr.FacilityId,
                    fr.ReservationId
                });
        }
    }
}
