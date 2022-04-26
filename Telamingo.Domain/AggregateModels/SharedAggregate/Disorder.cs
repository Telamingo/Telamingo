using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.SharedAggregate;

public class Disorder : Entity
{
    public string Name { get; set; }

    public IReadOnlyCollection<MentalHealthPossibilityOfExacerbationOfTheDisorder> mentalHealthPossibilityOfExacerbationOfTheDisorders => _mentalHealthPossibilityOfExacerbationOfTheDisorders;
    private readonly List<MentalHealthPossibilityOfExacerbationOfTheDisorder> _mentalHealthPossibilityOfExacerbationOfTheDisorders;

}
