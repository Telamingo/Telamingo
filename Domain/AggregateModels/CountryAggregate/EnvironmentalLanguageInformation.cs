using Domain.AggregateModels.SharedAggregate;
using Domain.SeedWork;

namespace Domain.AggregateModels.CountryAggregate;

public class EnvironmentalLanguageInformation : Entity
{
    public int EnvironmentalInformationId { get; set; }
    public virtual EnvironmentalInformation EnvironmentalInformation { get; set; }

    public int LanguageId { get; set; }
    public virtual Language Language { get; set; }
    public double Rate { get; set; }
}
