using Domain.SeedWork;
using System.Collections.Generic;

namespace Domain.AggregateModels.CountryAggregate
{
    public class EducationalInformation : Entity
    {
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }


        public IReadOnlyCollection<EducationalProbabilityOfAcceptance> educationalProbabilityOfAcceptances => _educationalProbabilityOfAcceptances;
        private readonly List<EducationalProbabilityOfAcceptance> _educationalProbabilityOfAcceptances;
        public IReadOnlyCollection<EducationalInformationTuition> educationalInformationTuitions => _educationalInformationTuitions;
        private readonly List<EducationalInformationTuition> _educationalInformationTuitions;

    }
}