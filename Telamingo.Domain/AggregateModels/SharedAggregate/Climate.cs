using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.SharedAggregate;

public class Climate : Entity
{
    public string Name { get; set; }
    public IReadOnlyCollection<CulturalClimateInformation> culturalClimateInformation => _culturalClimateInformation;
    private readonly List<CulturalClimateInformation> _culturalClimateInformation;

}
