using Domain.AggregateModels.CountryAggregate;
using Domain.SeedWork;

namespace Domain.AggregateModels.SharedAggregate;

public class Disorder : Entity
{
    public string Name { get; set; }

    public IReadOnlyCollection<MentalHealthPossibilityOfExacerbationOfTheDisorder> mentalHealthPossibilityOfExacerbationOfTheDisorders => _mentalHealthPossibilityOfExacerbationOfTheDisorders;
    private readonly List<MentalHealthPossibilityOfExacerbationOfTheDisorder> _mentalHealthPossibilityOfExacerbationOfTheDisorders;

}
