using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Dtos.CountryDtos
{
    public class CulturalDto
    {
        public ReligiousDto Religious { get; set; }
        public ImmigrationDto Immigration { get; set; }
        public SocialRelationshipMatchingDto SocialRelationshipMatching { get; set; }
    }

    public class ReligiousDto
    {
        public int HowCommittedAreYouToReligiousIssues { get; set; }
        public int HowImportantIsTheFutureOfIranForYou { get; set; }
    }
    public class ImmigrationDto
    {
        //public int HowImportantIsTheImmigrationOfTheDestinationCommunityToYou { get; set; }
        public int ImmigrationOfTheDestination { get; set; }
    }
    public class SocialRelationshipMatchingDto
    {
        //public int HowImportantIsThesimilarityOfTheCultureAndBehaviorOfTheDestinationCommunityToTheCommunityOfOrigin { get; set; }
        public int EnumSimilarityOfTheCulture { get; set; }
    }
}
