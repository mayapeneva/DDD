namespace CarRentalSystem.Domain.Models
{
    using Common;
    using Exceptions;

    using static Constants.ModelConstants.Options;

    internal class CarOptions : ValueObject
    {
        internal CarOptions(bool hasClimateControl, int numberOfSeats, CarTransmissionType transmissionType)
        {
            this.Validate(numberOfSeats);

            this.HasClimateControl = hasClimateControl;
            this.NumberOfSeats = numberOfSeats;
            this.TransmissionType = transmissionType;
        }

        public bool HasClimateControl { get; }

        public int NumberOfSeats { get; }

        public CarTransmissionType TransmissionType { get; }

        private void Validate(int numberOfSeats)
            => Guard.AgainstOutOfRange<InvalidOptionsException>(
                numberOfSeats,
                MinNumberOfSeats,
                MaxNumberOfSeats,
                nameof(this.NumberOfSeats));
    }
}
