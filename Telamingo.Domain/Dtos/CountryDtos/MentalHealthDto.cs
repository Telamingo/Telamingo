using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Dtos.CountryDtos
{
    public class MentalHealthDto
    {
        public ProbabilityOfDealingWithMentalIllnessDto ProbabilityOfDealingWithMentalIllness { get; set; }
        public VisitFamilyAndFriendsDto VisitFamilyAndFriends { get; set; }
    }
    public class ProbabilityOfDealingWithMentalIllnessDto
    {
        public int WhichOfTheFollowingDisordersDoYouHaveHistoryOf { get; set; }
    }
    public class VisitFamilyAndFriendsDto
    {
        public int HowManyTimesWeekDoYouVisitYourFamily { get; set; }
    }
}
