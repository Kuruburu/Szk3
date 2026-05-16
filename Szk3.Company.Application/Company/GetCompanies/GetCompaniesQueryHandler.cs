using MediatR;
using Microsoft.EntityFrameworkCore;
using Szk3.Company.Application.Common;
using Szk3.Company.Application.models;

namespace Szk3.Company.Application.Company.GetCompanies
{
    public sealed class GetJobPositionsQueryHandler : IRequestHandler<GetJobPositionsQuery, List<CompanyDto>>
    {
        private readonly ICompanyContext _companyContext;
        public GetJobPositionsQueryHandler(ICompanyContext companyContext) => _companyContext = companyContext;

        public async Task<List<CompanyDto>> Handle(GetJobPositionsQuery request, CancellationToken cancellationToken)
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
