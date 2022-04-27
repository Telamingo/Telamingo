using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.SharedAggregate;

public class FildOfStudy: Entity
{
    public string Name { get; set; }


    public IReadOnlyCollection<EducationalProbabilityOfAcceptance> educationalProbabilityOfAcceptances=> _educationalProbabilityOfAcceptances;
    private readonly List<EducationalProbabilityOfAcceptance> _educationalProbabilityOfAcceptances;

    public IReadOnlyCollection<EducationalInformationTuition> educationalInformationTuitions => _educationalInformationTuitions;
    private readonly List<EducationalInformationTuition> _educationalInformationTuitions;

}
