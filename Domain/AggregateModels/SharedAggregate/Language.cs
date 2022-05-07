using Domain.AggregateModels.CountryAggregate;
using Domain.SeedWork;

namespace Domain.AggregateModels.SharedAggregate;

public class Language : Entity
{
    public string Name { get; set; }

    public IReadOnlyCollection<EnvironmentalLanguageInformation> environmentalLanguageInformation => _environmentalLanguageInformation;
    private readonly List<EnvironmentalLanguageInformation> _environmentalLanguageInformation;
}
