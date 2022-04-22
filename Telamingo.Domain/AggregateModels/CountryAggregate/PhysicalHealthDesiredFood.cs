using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class PhysicalHealthDesiredFood : Entity
{
    public int FoodId { get; set; }
    public int PhysicalHealthInformationId { get; set; }
    public double Rate { get; set; }
}
