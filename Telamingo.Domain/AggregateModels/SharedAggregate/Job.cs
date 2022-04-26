using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.SharedAggregate;

public class Job: Entity
{
    public string Name { get; set; }
    public IReadOnlyCollection<WelfareInformation> welfareInformation=> _welfareInformation;
    private readonly List<WelfareInformation> _welfareInformation;

}
