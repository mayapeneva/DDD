namespace CarRentalSystem.Domain.Models
{
    using Common;
    using Exceptions;

    using static Constants.ModelConstants.Common;
    using static Constants.ModelConstants.CarAd;

    internal class CarAd : Entity<int>, IAggregateRoot
    {
        public CarAd(
            CarManufacturer manufacturer,
            string model,
            CarCategory category,
            string imageUrl,
            decimal pricePerDay,
            CarOptions options,
            bool isAvailable)
        {
            this.Validate(model, imageUrl, pricePerDay);

            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Category = category;
            this.ImageUrl = imageUrl;
            this.PricePerDay = pricePerDay;
            this.Options = options;
            this.IsAvailable = isAvailable;
        }

        public CarManufacturer Manufacturer { get; }

        public string Model { get; }

        public CarCategory Category { get; }

        public string ImageUrl { get; }

        public decimal PricePerDay { get; }

        public CarOptions Options { get; }

        public bool IsAvailable { get; private set; }

        public void ChangeAvailability() => this.IsAvailable = !this.IsAvailable;

        private void Validate(string model, string imageUrl, decimal pricePerDay)
        {
            Guard.ForStringLength<InvalidCarAdException>(
                model,
                MinModelLength,
                MaxModelLength,
                nameof(this.Model));

            Guard.ForValidUrl<InvalidCarAdException>(
                imageUrl,
                nameof(this.ImageUrl));

            Guard.AgainstOutOfRange<InvalidCarAdException>(
                pricePerDay,
                Zero,
                decimal.MaxValue,
                nameof(this.PricePerDay));
        }
    }
}