using Domain.SeedWork;

namespace Domain.AggregateModels.CountryAggregate;

public class LanguageInformation : Entity
{
    public int CountryId { get; set; }
    public virtual Country Country { get; set; }

    public string LanguageName { get; set; }
    public double LanguageEpidemicRates { get; set; }
}
