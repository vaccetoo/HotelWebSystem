using HotelApp.Infrastructure.Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Infrastructure.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void ApplyConfigurations(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FacilityReservationConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationParticipantConfiguration());
        }
    }
}
