namespace HotelApp.Common.Constants
{
    public static class ValidationConstants
    {
        // Room validation constants
        public const decimal RoomMinPrice = 0.00m;
        public const decimal RoomMaxPrice = 10_000m;

        public const int RoomMinCapacity = 1;
        public const int RoomMaxCapacity = 4;

        // Guest validation constants
        public const int FirstNameMinLength = 1;
        public const int FirstNameMaxLength = 55;

        public const int LastNameMinLength = 1;
        public const int LastNameMaxLength = 55;

        // Facility validation constants
        public const int FacilityDescriptionMinLength = 6;
        public const int FacilityDescriptionMaxLength = 525;

        public const decimal FacilityMinPrice = 0.00m;
        public const decimal FacilityMaxPrice = 1_000m;

        // Review validation constants
        public const int ReviewMinRaiting = 1;
        public const int ReviewMaxRaiting = 6;

        public const int ReviewCommentMinLength = 3;
        public const int ReviewCommentMaxLength = 1025;

        // Common validation constants
        public const string PhoneNumberPattern = @"^\+\d{12,}$";
        public const string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        public const string DateFormat = "dddd, dd MMMM yyyy";
        public const int DecimalPrecision = 18; 
        public const int DecimalScale = 2;
    }
}
