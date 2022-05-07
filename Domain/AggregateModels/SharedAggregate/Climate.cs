using Domain.AggregateModels.CountryAggregate;
using Domain.SeedWork;

namespace Domain.AggregateModels.SharedAggregate;

public class Climate : Entity
{
    public string Name { get; set; }
    public IReadOnlyCollection<CulturalClimateInformation> culturalClimateInformation => _culturalClimateInformation;
    private readonly List<CulturalClimateInformation> _culturalClimateInformation;

}
