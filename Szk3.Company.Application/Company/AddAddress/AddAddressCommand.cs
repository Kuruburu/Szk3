using MediatR;

namespace Szk3.Company.Application.Company.AddAddress
{
    public sealed record AddAddressCommand(
        string street, string buildingNumber, string? apartmentNumber, string postalCode,
        string city, string country, bool isActive = true
        ): IRequest<int> { }
}
