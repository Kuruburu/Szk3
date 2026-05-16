using MediatR;
using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szk3.Country.Application.Country.AddCity
{
    public sealed record AddCompanyCommand(int CountryId, string Name, bool IsActive = true): IRequest<int>
    {
    }
    
}
