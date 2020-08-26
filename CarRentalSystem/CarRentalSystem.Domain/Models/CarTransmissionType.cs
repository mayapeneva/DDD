namespace CarRentalSystem.Domain.Models
{
    using Common;

    internal class CarTransmissionType : Enumeration
    {
        public static readonly CarTransmissionType Manual = new CarTransmissionType(1, nameof(Manual));
        public static readonly CarTransmissionType Automatic = new CarTransmissionType(2, nameof(Automatic));

        private CarTransmissionType(int value, string name)
            : base(value, name)
        {
        }
    }
}
