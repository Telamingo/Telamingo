using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.SharedAggregate;

public class Weather : Entity
{
    public string Name { get; set; }

    public IReadOnlyCollection<CulturalweatherInformation> culturalweatherInformation => _culturalweatherInformation;
    private readonly List<CulturalweatherInformation> _culturalweatherInformation;

}
