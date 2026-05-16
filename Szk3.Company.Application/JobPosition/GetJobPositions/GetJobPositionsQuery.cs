using MediatR;
using Szk3.Company.Application.models;

namespace Szk3.Company.Application.JobPosition.GetJobPositions
{
    public sealed record GetJobPositionsQuery(): IRequest<List<CompanyDto>>;
}
