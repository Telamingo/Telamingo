using Domain.AggregateModels.CountryAggregate;
using Domain.SeedWork;
using System.Collections.Generic;

namespace Domain.AggregateModels.SharedAggregate
{
    public class FildOfStudy : Entity
    {
        public string Name { get; set; }


        public IReadOnlyCollection<EducationalProbabilityOfAcceptance> educationalProbabilityOfAcceptances => _educationalProbabilityOfAcceptances;
        private readonly List<EducationalProbabilityOfAcceptance> _educationalProbabilityOfAcceptances;

        public IReadOnlyCollection<EducationalInformationTuition> educationalInformationTuitions => _educationalInformationTuitions;
        private readonly List<EducationalInformationTuition> _educationalInformationTuitions;

    }
}