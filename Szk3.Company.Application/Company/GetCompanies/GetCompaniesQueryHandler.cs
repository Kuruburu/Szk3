using MediatR;
using Microsoft.EntityFrameworkCore;
using Szk3.Company.Application.Common;
using Szk3.Company.Application.models;

namespace Szk3.Company.Application.Company.GetCompanies
{
    public sealed class GetCompaniesQueryHandler : IRequestHandler<GetCompaniesQuery, List<CompanyDto>>
    {
        private readonly ICompanyContext _companyContext;
        public GetCompaniesQueryHandler(ICompanyContext companyContext) => _companyContext = companyContext;

        public async Task<List<CompanyDto>> Handle(GetCompaniesQuery request, CancellationToken cancellationToken)
        {
            var companies = await _companyContext.CompanyQuery.Select(x => new CompanyDto
            {
                Addresses = (List<Domain.Entities.Company.CompanyAddress>)x.Addresses,
                KRAZ = x.KRAZ,
                Name = x.Name,
                NIP = x.NIP,
                Owners = (List<Domain.Entities.Company.CompanyOwner>)x.Owners,
                ShortName = x.ShortName,
                KRS = x.KRS,
                REGON = x.REGON,
            }).ToListAsync(cancellationToken);
            return companies;
        }
    }
}
