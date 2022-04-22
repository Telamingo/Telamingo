using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class CulturalClimateInformation: Entity
{
    public int ClimateId { get; set; }
    public int CulturalInformationId { get; set; }
    public double Rate { get; set; }
}
