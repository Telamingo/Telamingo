using Domain.AggregateModels.SharedAggregate;
using Domain.SeedWork;

namespace Domain.AggregateModels.CountryAggregate
{
    public class PhysicalHealthDesiredFood : Entity
    {
        public int FoodId { get; set; }
        public virtual Food Food { get; set; }

        public int PhysicalHealthInformationId { get; set; }
        public virtual PhysicalHealthInformation PhysicalHealthInformation { get; set; }

        public double Rate { get; set; }
    }
}