using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.SharedAggregate;

public class Language : Entity
{
    public string Name { get; set; }

    public IReadOnlyCollection<EnvironmentalLanguageInformation> environmentalLanguageInformation => _environmentalLanguageInformation;
    private readonly List<EnvironmentalLanguageInformation> _environmentalLanguageInformation;
}
