using Telamingo.Domain.AggregateModels.SharedAggregate;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class MentalHealthPossibilityOfExacerbationOfTheDisorder: Entity
{
    public int MentalHealthInformationId { get; set; }
    public virtual MentalHealthInformation MentalHealthInformation { get; set; }

    public int DisorderId { get; set; }
    public virtual Disorder Disorder { get; set; }
    public double Possibility { get; set; }

}
