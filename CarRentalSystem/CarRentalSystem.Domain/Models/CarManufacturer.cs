namespace CarRentalSystem.Domain.Models
{
    using Common;
    using Exceptions;

    using static Constants.ModelConstants.Common;

    internal class CarManufacturer : Entity<int>
    {
        internal CarManufacturer(string name)
        {
            this.Validate(name);

            this.Name = name;
        }

        public string Name { get; }

        public void Validate(string name)
            => Guard.ForStringLength<InvalidCarAdException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
    }
}
