namespace CarRentalSystem.Domain.Exceptions
{
    internal class InvalidCarAdException : BaseDomainException
    {
        public InvalidCarAdException()
        {
        }

        public InvalidCarAdException(string message) => this.Message = message;
    }
}
