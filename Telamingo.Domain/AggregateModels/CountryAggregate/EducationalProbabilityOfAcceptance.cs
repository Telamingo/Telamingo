using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class EducationalProbabilityOfAcceptance: Entity
{
    public int EducationalInformationId { get; set; }
    public int FildOfStudyId { get; set; }
    public double Rate { get; set; }
}
