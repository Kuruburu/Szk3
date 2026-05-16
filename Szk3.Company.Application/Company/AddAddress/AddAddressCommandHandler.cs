using MediatR;
using Microsoft.EntityFrameworkCore;
using Szk3.Company.Application.Common;


namespace Szk3.Company.Application.Company.AddAddress
{
    public sealed class AddAddressCommandHandler: IRequestHandler<AddAddressCommand, int>
    {
        private readonly ICompanyContext _companyContext;
        public AddAddressCommandHandler(ICompanyContext companyContext)
        {
            _countryContext = companyContext;
        }

        public async Task<int> Handle(AddCompanyCommand request, CancellationToken cancellationToken)
        {
            var country = await _countryContext.Countries.FirstOrDefaultAsync(x => x.Id == request.CountryId, cancellationToken);
            if (country is null)
            {
                throw new InvalidOperationException($"Country with id '{request.CountryId}' does not exist..");
            }
            var cityName = request.Name.Trim();
            var cityExists = country.Cities.Any(x => x.Name.ToLower() == cityName.ToLower());
            if (cityExists) {
                throw new InvalidOperationException($"City with name '{request.Name}' already exists in country '{country.Name}'");
            }
            country.AddCity(cityName, request.IsActive);
            await _countryContext.SaveChangesAsync(cancellationToken);
            var addedCity = country.Cities.Last();
            return addedCity.Id;
        }
    }
   
    
}
