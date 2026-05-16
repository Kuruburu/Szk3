namespace Szk3.Company.Application.Common;

using Microsoft.EntityFrameworkCore;
using Szk3.Common.Application.Interfaces;

public interface ICompanyContext : IQueryContext, IContext
{
    DbSet<Szk3.Company.Domain.Entities.JobPosition.JobPosition> JobPosition { get; }
    DbSet<Szk3.Company.Domain.Entities.JobPosition.PositionRate> PositionRate { get; }
    DbSet<Szk3.Company.Domain.Entities.JobPosition.PositionRequirement> PositionRequirement { get; }
    DbSet<Szk3.Company.Domain.Entities.Company.Company>  Company { get; }
    DbSet<Szk3.Company.Domain.Entities.Company.CompanyAddress> CompanyAddresses { get; }
    DbSet<Szk3.Company.Domain.Entities.Company.CompanyOwner> CompanyOwner { get; }
}
