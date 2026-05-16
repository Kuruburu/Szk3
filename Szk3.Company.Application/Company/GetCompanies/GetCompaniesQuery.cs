using MediatR;
using Szk3.Company.Application.models;

namespace Szk3.Company.Application.Company.GetCompanies
{
    public sealed record GetJobPositionsQuery(): IRequest<List<CompanyDto>>;
}
