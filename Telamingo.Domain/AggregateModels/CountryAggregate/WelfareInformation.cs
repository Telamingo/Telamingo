using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class WelfareInformation : Entity
{
    public int CountryId { get; set; }
    public int JobId { get; set; }
    public double AnnualSavingsRates { get; set; }
    public double RequiredSpecialization { get; set; }
}
