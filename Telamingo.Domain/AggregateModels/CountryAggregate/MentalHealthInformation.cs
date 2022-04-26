using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class MentalHealthInformation: Entity
{
    public int CountryId { get; set; }
    public int AbilityToVisitFamily { get; set; }
}
