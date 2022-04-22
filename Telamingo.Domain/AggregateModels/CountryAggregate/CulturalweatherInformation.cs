using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class CulturalweatherInformation: Entity
{
    public int CulturalInformationId { get; set; }
    public int WeatherId { get; set; }
    public double Rate { get; set; }
}
