using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate
{
    public class EnvironmentalInformation: Entity
    {
        public int CountryId { get; set; }
        public int ReligiousIssues { get; set; }
        public int Immigration { get; set; }
        public int SocialRelationshipMatching { get; set; }
    }
}
