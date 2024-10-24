namespace HotelApp.Common.Constants
{
    public static class ValidationConstants
    {
        // Reservation validation constants
        public const decimal TotalPriceMinValue = 0m;
        public const decimal TotalPriceMaxValue = 10_000m;

        // Common validation constants
        public const int RequiredPrecision = 18;
        public const int RequiredScale = 2;
    }
}
