using Domain.AggregateModels.SharedAggregate;
using Domain.SeedWork;

namespace Domain.AggregateModels.CountryAggregate;

public class EducationalProbabilityOfAcceptance : Entity
{
    public int EducationalInformationId { get; set; }
    public virtual EducationalInformation EducationalInformation { get; set; }

    public int FildOfStudyId { get; set; }
    public virtual FildOfStudy FildOfStudy { get; set; }
    public double Rate { get; set; }
}
