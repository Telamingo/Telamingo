using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Enums;
#region    PersonalInfo
public enum EnumCurentCuntry
{
    Iran = 0,
    Canada = 1,
}
public enum EnumMigrationType
{
    Educational = 0,
    Work = 1,
}
public enum EnumTargetCuntry
{
    Canada = 0,
    Iran = 1,
}
public enum EnumFieldOfStudy
{
    Math = 0,
    Psychology = 1,
}
public enum EnumUniversity
{
    Sharif = 0,
    Tehran = 1,
    AmirKabir = 2,

}
public enum EnumCurentCity
{
    Tehran = 0,
    Shiraz = 1,
    Tabriz = 2,
}
public enum EnumJobType
{
    Webdeveloper = 0,
    Doktor = 1,
    Tailor = 2,
}
public enum EnumWorkExperience
{
    Year1 = 0,
    Year2 = 1,
    Year3 = 2,
}
public enum EnumFinancialSituation
{
    Low = 0,
    Medium = 1,
    High = 2,
}
#endregion

#region Religious

public enum EnumHowCommittedAreYouToReligiousIssues
{
    IWantToGetRidOfValueConstraints = 1,
    DoesNotMatter = 2,
    ItIsImportantToMe = 3,
}
public enum EnumHowImportantIsTheFutureOfIranForYou
{
    DoesNotMatter = 2,
    ItIsImportantToMe = 3,
}
public enum EnumHowImportantIsTheImmigrationOfTheDestinationCommunityToYou
{
    IDoNotLikeToBeImmigrant = 1,
    DoesNotMatter = 2,
    ItIsImportantToMe = 3,
}
//===========================================================================
//public enum EnumHowImportantIsThesimilarityOfTheCultureAndBehaviorOfTheDestinationCommunityToTheCommunityOfOrigin
//{
//    ILikeToBeDifferent = 1,
//    DoesNotMatter = 2,
//    ItIsImportantToMe = 3,
//}
public enum EnumSimilarityOfTheCulture
{
    ILikeToBeDifferent = 1,
    DoesNotMatter = 2,
    ItIsImportantToMe = 3,
}
//===========================================================================
#endregion

#region PhysicalHealth

public enum EnumDoYouHaveSpecificIllness
{
    No = 0,
    Yes = 1,
}
public enum EnumApplicantsFoodLifestyle
{
    DoesNotMatter = 0,
    Vegetarian = 1,
    FastFood = 2,
    Iranian = 3,
}
public enum EnumHowManyTimesYearDoYouOrYourFamilyUsuallySeeDoctor
{
    Alot = 1,
    Medium = 2,
    Low = 3,
}
//public enum EnumHowMuchDoYouExpectToSpendOnYourTreatmentAndMedicalIssuesDuringTheYear
//{
//    InDolars1000to2000 = 0,
//    InDolars2000to3000 = 1,
//    InDolars3000to4000 = 2,
//}
#endregion

#region MentalHealth

public enum EnumWhichOfTheFollowingDisordersDoYouHaveHistoryOf
{
    Non = 0,
    Anxiety = 1,
    MinorDepression = 2,
    MajorDpression = 3,
    AversionToSociety = 4,
    Bipolar = 5,
    Obsession = 6,
}
public enum EnumHowManyTimesWeekDoYouVisitYourFamily
{
    Alot = 1,
    Medium = 2,
    Low = 3,
}
#endregion

#region Environmental

public enum EnumWhatIsYourUnfavorableWeather
{
    Non = 0,
    Mountainous = 1,
    Equatorial = 2,
    Monsoon = 3,
    Desert = 4,
    MountainBase = 5,
    ModerateMediterranean = 6
}
public enum EnumProblemsWithDayAndNightHours
{
    Non = 0,
    LongNight = 1,
    LongDay = 2,
    MostlyCloudy = 3,
    MostlySunny = 4,
}
#endregion

#region Educational

public enum EnumAcademicResume
{
    Engineering = 0,
    MedicineAndPharmacy = 1,
    law = 2,
    Management = 3,
    Psychology = 4,
    Humanities = 5,
    Art = 6,
    Science = 7,
}
#endregion

#region Welfare
public enum EnumWhatIsYourJobOrSkillNow
{
    Webdeveloper = 0,
    Doktor = 1,
    Tailor = 2,
}
public enum EnumWhatJobDoYouWantToPursueAfterEmigrating
{
    Tailor = 0,
    Enjinier = 1,
    Manager = 2,
    Doktor = 3
}
#endregion
public enum EnumLanguageLevel
{
    Non = 0,
    BEGINNER = 1,
    INTERMEDIATE = 2,
    ADVANCE = 3,
}
