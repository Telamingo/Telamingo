using Domain.AggregateModels.SharedAggregate;
using Domain.SeedWork;

namespace Domain.AggregateModels.CountryAggregate;

public class MentalHealthPossibilityOfExacerbationOfTheDisorder : Entity
{
    public int MentalHealthInformationId { get; set; }
    public virtual MentalHealthInformation MentalHealthInformation { get; set; }

    public int DisorderId { get; set; }
    public virtual Disorder Disorder { get; set; }
    public double Possibility { get; set; }

}
