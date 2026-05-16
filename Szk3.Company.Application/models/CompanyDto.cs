using Szk3.Company.Domain.Entities.Company;

namespace Szk3.Company.Application.models
{
    public sealed class CompanyDto
    {
        public string Name { get; set; } = null!;

        public string ShortName { get; set; } = null!;

        public string? NIP { get; set; }

        public string? REGON { get; set; }

        public string? KRAZ { get; set; }

        public string? KRS { get; set; }

        public List<CompanyAddress>? Addresses;

        public List<CompanyOwner>? Owners;

    }
}
