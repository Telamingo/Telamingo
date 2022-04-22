using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class EnvironmentalLanguageInformation : Entity
{
    public int EnvironmentalInformationId { get; set; }
    public int LanguageId { get; set; }
    public double Rate { get; set; }
}
