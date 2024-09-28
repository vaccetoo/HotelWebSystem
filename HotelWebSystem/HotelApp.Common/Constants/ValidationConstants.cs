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

        // Common validation constants
        public const string PhoneNumberPattern = @"^\+\d{12,}$";
        public const string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        public const string DateFormat = "dddd, dd MMMM yyyy";
    }
}
