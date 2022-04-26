using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class MentalHealthPossibilityOfExacerbationOfTheDisorder: Entity
{
    public int MentalHealthInformationId { get; set; }
    public int DisorderId { get; set; }
    public double Possibility { get; set; }

}
