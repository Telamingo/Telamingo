using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class PossibilityOfExacerbationOfTheDisorder: Entity
{
    public int DisorderId { get; set; }
    public int MentalHealthInformationId { get; set; }
    public double Possibility { get; set; }
}
