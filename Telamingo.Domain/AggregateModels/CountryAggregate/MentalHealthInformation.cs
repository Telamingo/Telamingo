using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class MentalHealthInformation: Entity
{
    public int CountryId { get; set; }
    public double PossibilityOfExacerbationOfTheDisorder { get; set; }
    public double AbilityToVisitFamily { get; set; }
}
