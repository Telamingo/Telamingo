using Domain.AggregateModels.CountryAggregate;
using Domain.SeedWork;

namespace Domain.AggregateModels.SharedAggregate;

public class Food : Entity
{
    public string Name { get; set; }

    public IReadOnlyCollection<PhysicalHealthDesiredFood> physicalHealthDesiredFoods => _physicalHealthDesiredFoods;
    private readonly List<PhysicalHealthDesiredFood> _physicalHealthDesiredFoods;

}
