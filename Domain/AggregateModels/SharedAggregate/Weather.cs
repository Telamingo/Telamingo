using Domain.AggregateModels.CountryAggregate;
using Domain.SeedWork;

namespace Domain.AggregateModels.SharedAggregate;

public class Weather : Entity
{
    public string Name { get; set; }

    public IReadOnlyCollection<CulturalweatherInformation> culturalweatherInformation => _culturalweatherInformation;
    private readonly List<CulturalweatherInformation> _culturalweatherInformation;

}
