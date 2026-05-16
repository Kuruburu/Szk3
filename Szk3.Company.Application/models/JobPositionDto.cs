using Szk3.Company.Domain.Entities.JobPosition;

namespace Szk3.Company.Application.models
{
    public class JobPositionDto
    {

    public string Name { get; private set; } = null!;
    public string? Code { get; private set; }
    public bool IsActive { get; private set; }

    public List<PositionRate> Rates = new();

    public List<PositionRequirement> Requirement = new();
    }
}
