using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate
{
    public class EnvironmentalInformation: Entity
    {
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public int ReligiousIssues { get; set; }
        public int Immigration { get; set; }
        public int SocialRelationshipMatching { get; set; }

        public IReadOnlyCollection<EnvironmentalLanguageInformation> environmentalLanguageInformation => _environmentalLanguageInformation;
        private readonly List<EnvironmentalLanguageInformation> _environmentalLanguageInformation;

    }
}
