using Telamingo.Domain.AggregateModels.SharedAggregate;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class CulturalweatherInformation: Entity
{
    public int CulturalInformationId { get; set; }
    public virtual CulturalInformation CulturalInformation { get; set; }

    public int WeatherId { get; set; }
    public virtual Weather Weather{ get; set; }
    public double Rate { get; set; }
}
