using Telamingo.Domain.AggregateModels.SharedAggregate;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class PhysicalHealthDesiredFood : Entity
{
    public int FoodId { get; set; }
    public virtual Food Food { get; set; }

    public int PhysicalHealthInformationId { get; set; }
    public virtual PhysicalHealthInformation PhysicalHealthInformation { get; set; }

    public double Rate { get; set; }
}
