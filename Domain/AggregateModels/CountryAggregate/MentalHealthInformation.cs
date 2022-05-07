using Domain.SeedWork;

namespace Domain.AggregateModels.CountryAggregate;

public class MentalHealthInformation : Entity
{
    public int CountryId { get; set; }
    public virtual Country Country { get; set; }

    public int AbilityToVisitFamily { get; set; }

    public IReadOnlyCollection<MentalHealthPossibilityOfExacerbationOfTheDisorder> mentalHealthPossibilityOfExacerbationOfTheDisorders => _mentalHealthPossibilityOfExacerbationOfTheDisorders;
    private readonly List<MentalHealthPossibilityOfExacerbationOfTheDisorder> _mentalHealthPossibilityOfExacerbationOfTheDisorders;

}
