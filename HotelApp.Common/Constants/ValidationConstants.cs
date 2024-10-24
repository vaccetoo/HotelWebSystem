namespace HotelApp.Common.Constants
{
    public static class ValidationConstants
    {
        // Reservation validation constants
        public const decimal ReservationTotalPriceMinValue = 0m;
        public const decimal ReservationTotalPriceMaxValue = 50_000m;

        // Guest validation constants
        public const int GuestFullNameMinLength = 5;
        public const int GuestFullNameMaxLength = 55;

        // Facility validation constants
        public const int FacilityDescriptionMinLength = 5;
        public const int FacilityDescriptionMaxLength = 520;

        // Review validation constants
        public const int ReviewCommentMinLength = 2;
        public const int ReviewCommentMaxLength = 1025;

        // Common validation constants
        public const int RequiredPrecision = 18;
        public const int RequiredScale = 2;

        public const string PhoneNumberPattern = @"^\+[\d]{8,15}$";
        public const string EmailAddressPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
    }
}
