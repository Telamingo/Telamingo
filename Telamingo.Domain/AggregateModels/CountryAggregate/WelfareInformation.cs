using Telamingo.Domain.AggregateModels.SharedAggregate;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class WelfareInformation : Entity
{
    public int CountryId { get; set; }
    public virtual Country Country { get; set; }

    public int JobId { get; set; }
    public virtual Job Job { get; set; }

    public double AnnualSavingsRates { get; set; }
    public double RequiredSpecialization { get; set; }
}
