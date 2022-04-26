using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.SharedAggregate;

public class Food : Entity
{
    public string Name { get; set; }

    public IReadOnlyCollection<PhysicalHealthDesiredFood> physicalHealthDesiredFoods => _physicalHealthDesiredFoods;
    private readonly List<PhysicalHealthDesiredFood> _physicalHealthDesiredFoods;

}
