using Domain.AggregateModels.SharedAggregate;
using Domain.SeedWork;

namespace Domain.AggregateModels.CountryAggregate
{
    public class CulturalClimateInformation : Entity
    {
        public int ClimateId { get; set; }
        public virtual Climate Climate { get; set; }

        public int CulturalInformationId { get; set; }
        public virtual CulturalInformation CulturalInformation { get; set; }

        public double Rate { get; set; }
    }
}