using Domain.Dtos.CountryDtos;
using Domain.Dtos.User;
using System.Threading;

namespace BusinessLogic.Actions.Calculation
{
    public class CalculationService : ICalculationService
    {
        public ResultDto GetAsync(UserAnswers model, CancellationToken cancellationToken)
        {
            double a = PersonalInformation(model.PersonalInformation);

            double lang = CaLanguage(model.Language);
            ResultDto result = new();
            result.Cultural = CaCultural(model.Cultural, lang);
            result.PhysicalHealth = CaPhysicalHealth(model.PhysicalHealth);
            result.MentalHealth = CaMentalHealth(model.MentalHealth);
            result.Environmental = CaEnvironmental(model.Environmental);
            result.Educational = CaEducational(model.Educational, lang);
            result.Welfare = CaWelfare(model.Welfare);

            result.Result = result.Cultural * 0.16 + result.PhysicalHealth * 0.11 + result.MentalHealth * 0.09 +
                result.Environmental * 0.14 + result.Educational * 0.07 + result.Welfare * 0.23;

            return result;
        }

        private static double PersonalInformation(PersonalInformationDto personalInformation)
        {
            var result = 0;
            return result;
        }

        #region Canada
        private static double CaWelfare(WelfareDto welfare)
        {
            double need = 0;
            double saving = 0;
            switch (welfare.Specialty.WhatJobDoYouWantToPursueAfterEmigrating)
            {
                case 0:
                    need = 0.7;
                    saving = 12000 / welfare.Saving.HowMuchDoYouExpectToSaveAnnually;
                    break;
                case 1:
                    need = 0.8;
                    saving = 10028 / welfare.Saving.HowMuchDoYouExpectToSaveAnnually;
                    break;
                case 2:
                    need = 0.2;
                    saving = 9607 / welfare.Saving.HowMuchDoYouExpectToSaveAnnually;
                    break;
                case 3:
                    need = 0.5;
                    saving = 10569 / welfare.Saving.HowMuchDoYouExpectToSaveAnnually;
                    break;
            }
            if (saving > 1)
            {
                saving = 1;
            }
            if (saving < 0)
            {
                saving = 0;
            }
            return need * 0.2 + saving * 0.8;
        }
        private static double CaLanguage(LanguageDto model)
        {
            double lang1 = 0;
            double lang2 = 0;
            switch (model.FirstLanguageLevel)
            {
                case 0:
                    lang1 = 0;
                    break;
                case 1:
                    lang1 = 0.34 * 0.7;
                    break;
                case 2:
                    lang1 = 0.67 * 0.7;
                    break;
                case 3:
                    lang1 = 1 * 0.7;
                    break;
            }
            switch (model.SecondLanguageLevel)
            {
                case 0:
                    lang2 = 0;
                    break;
                case 1:
                    lang2 = 0.34 * 0.3;
                    break;
                case 2:
                    lang2 = 0.67 * 0.3;
                    break;
                case 3:
                    lang2 = 1 * 0.3;
                    break;
            }

            return lang1 + lang2;
        }
        private static double CaCultural(CulturalDto cultural, double lang)
        {
            double re = 0;
            switch (cultural.Religious.HowCommittedAreYouToReligiousIssues)
            {
                case 1:
                    re = 1 / 1;
                    break;
                case 2:
                    re = 1 / 2;
                    break;
                case 3:
                    re = 1 / 3;
                    break;
            }
            if (re > 1)
            {
                re = 1;
            }
            double im = 0;
            switch (cultural.Immigration.ImmigrationOfTheDestination)
            {
                case 1:
                    im = 2 / 1;
                    break;
                case 2:
                    im = 2 / 2;
                    break;
                case 3:
                    im = 2 / 3;
                    break;
            }
            if (im > 1)
            {
                im = 1;
            }
            double Similarity = 0;
            switch (cultural.SocialRelationshipMatching.EnumSimilarityOfTheCulture)
            {
                case 1:
                    Similarity = 3 / 1;
                    break;
                case 2:
                    Similarity = 3 / 2;
                    break;
                case 3:
                    Similarity = 3 / 3;
                    break;
            }
            if (Similarity > 1)
            {
                Similarity = 1;
            }

            double result = re * 0.2 + im * 0.15 + Similarity * 0.25 + lang * 0.4;

            return result;
        }
        private static double CaPhysicalHealth(PhysicalHealthDto physicalHealth)
        {
            double illness = 0;
            switch (physicalHealth.HealthSystemForPatients.DoYouHaveSpecificIllness)
            {
                case 0:
                    illness = 0 * 0.4;
                    break;
                case 1:
                    illness = 1 * 0.4;
                    break;
            }

            double food = 0;
            switch (physicalHealth.ApplicantsFoodLifestyle.Option)
            {
                case 0:
                    food = 1;
                    break;
                case 1:
                    food = 0.2;
                    break;
                case 2:
                    food = 0.3;
                    break;
                case 3:
                    food = 0.1;
                    break;
            }
            double draccess = 0;
            switch (physicalHealth.NeedToAccessDoctor.HowManyTimesYearDoYouOrYourFamilyUsuallySeeDoctor)
            {
                case 1:
                    draccess = 1 / 3;
                    break;
                case 2:
                    draccess = 2 / 3;
                    break;
                case 3:
                    draccess = 3 / 3;
                    break;
            }
            if (draccess <= 0.34)
            {
                draccess = 0;
            }
            double SpendsOnTreatment;
            var q = 10639 / physicalHealth.HealthCostsToSavings.SpendsOnTreatment;
            if (q > 1)
            {
                SpendsOnTreatment = 1;
            }
            else if (q < 0)
            {
                SpendsOnTreatment = 0;
            }
            else
            {
                SpendsOnTreatment = q;
            }

            var result = illness * 0.5 + food * 0.1 + draccess * 0.2 + SpendsOnTreatment * 0.3;
            return result;
        }
        private static double CaMentalHealth(MentalHealthDto mentalHealth)
        {
            double mantal = 0;
            switch (mentalHealth.ProbabilityOfDealingWithMentalIllness.WhichOfTheFollowingDisordersDoYouHaveHistoryOf)
            {
                case 0:
                    mantal = 1 - 0;
                    break;
                case 1:
                    mantal = 1 - 0.9;
                    break;
                case 2:
                    mantal = 1 - 1;
                    break;
                case 3:
                    mantal = 1 - 0.9;
                    break;
                case 4:
                    mantal = 1 - 0.5;
                    break;
                case 5:
                    mantal = 1 - 0.7;
                    break;
                case 6:
                    mantal = 1 - 0.7;
                    break;
            }
            double family = 0;
            switch (mentalHealth.VisitFamilyAndFriends.HowManyTimesWeekDoYouVisitYourFamily)
            {
                case 1:
                    family = 1 / 3;
                    break;
                case 2:
                    family = 2 / 3;
                    break;
                case 3:
                    family = 3 / 3;
                    break;
            }
            if (family <= 0.34)
            {
                family = 0;
            }
            var result = mantal * 0.4 + family * 0.6;
            return result;
        }
        private static double CaEnvironmental(EnvironmentalDto environmental)
        {
            double Weather = 0;
            switch (environmental.TemperatureAndWeather.WhatIsYourUnfavorableWeather)
            {
                case 0:
                    Weather = 1;
                    break;
                case 1:
                    Weather = 1 - 0.03;
                    break;
                case 2:
                    Weather = 1 - 0.21;
                    break;
                case 3:
                    Weather = 1 - 0.03;
                    break;
                case 4:
                    Weather = 1 - 0.28;
                    break;
                case 5:
                    Weather = 1 - 0.28;
                    break;
                case 6:
                    Weather = 1 - 0.17;
                    break;
            }
            double Hours = 0;
            switch (environmental.Climate.ProblemsWithDayAndNightHours)
            {
                case 0:
                    Hours = 1 - 1;
                    break;
                case 1:
                    Hours = 1 - 0;
                    break;
                case 2:
                    Hours = 1 - 0;
                    break;
                case 3:
                    Hours = 1 - 0;
                    break;
                case 4:
                    Hours = 1 - 0;
                    break;
            }

            var result = Weather * 0.67 + Hours * 0.33;
            return result;
        }
        private static double CaEducational(EducationalDto educational, double lang)
        {
            double prob = 0;
            double exp = 0;
            switch (educational.ProbabilityOfAcceptance.AcademicResume)
            {
                case 0:
                    prob = 1;
                    exp = 11541 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 1:
                    prob = 0.2;
                    exp = 25847 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 2:
                    prob = 0.5;
                    exp = 8380 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 3:
                    prob = 0.7;
                    exp = 32519 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 4:
                    prob = 0.8;
                    exp = 35465 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 5:
                    prob = 0.4;
                    exp = 24128 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 6:
                    prob = 0.9;
                    exp = 22252 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 7:
                    prob = 0.8;
                    exp = 6744 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
            }
            if (exp > 1)
            {
                exp = 1;
            }
            if (exp < 0)
            {
                exp = 0;
            }

            var result = prob * 0.3 + exp * 0.3 + lang * 0.4;
            return result;
        }

        #endregion
        #region England
        private static double EnCultural(CulturalDto cultural, double lang)
        {
            double re = 0;
            switch (cultural.Religious.HowCommittedAreYouToReligiousIssues)
            {
                case 1:
                    re = 1 / 1;
                    break;
                case 2:
                    re = 1 / 2;
                    break;
                case 3:
                    re = 1 / 3;
                    break;
            }
            if (re > 1)
            {
                re = 1;
            }
            double im = 0;
            switch (cultural.Immigration.ImmigrationOfTheDestination)
            {
                case 1:
                    im = 2 / 1;
                    break;
                case 2:
                    im = 2 / 2;
                    break;
                case 3:
                    im = 2 / 3;
                    break;
            }
            if (im > 1)
            {
                im = 1;
            }
            double Similarity = 0;
            switch (cultural.SocialRelationshipMatching.EnumSimilarityOfTheCulture)
            {
                case 1:
                    Similarity = 3 / 1;
                    break;
                case 2:
                    Similarity = 3 / 2;
                    break;
                case 3:
                    Similarity = 3 / 3;
                    break;
            }

            var result = re * 0.2 + im * 0.2 + Similarity * 0.3 + lang * 0.4;

            return result;
        }
        private static double EnPhysicalHealth(PhysicalHealthDto physicalHealth)
        {
            double ill = 0;
            if (physicalHealth.HealthSystemForPatients.DoYouHaveSpecificIllness == 1)
            {
                ill = 0.4;
            }
            double food = 0;
            switch (physicalHealth.ApplicantsFoodLifestyle.Option)
            {
                case 0:
                    food = 1;
                    break;
                case 1:
                    food = 0.2;
                    break;
                case 2:
                    food = 0.3;
                    break;
                case 3:
                    food = 0.1;
                    break;
            }
            double draccess = 0;
            switch (physicalHealth.NeedToAccessDoctor.HowManyTimesYearDoYouOrYourFamilyUsuallySeeDoctor)
            {
                case 1:
                    draccess = 0;
                    break;
                case 2:
                    draccess = 0.5;
                    break;
                case 3:
                    draccess = 1;
                    break;
            }
            switch (physicalHealth.HealthCostsToSavings.SpendsOnTreatment)
            {
                case 1:
                    draccess = 0;
                    break;
                case 2:
                    draccess = 0.5;
                    break;
                case 3:
                    draccess = 1;
                    break;
            }
            double SpendsOnTreatment = 0;
            var q = 10639 / physicalHealth.HealthCostsToSavings.SpendsOnTreatment;
            if (q > 1)
            {
                SpendsOnTreatment = 1;
            }
            else if (q < 0)
            {
                SpendsOnTreatment = 0;
            }
            else
            {
                SpendsOnTreatment = q;
            }

            var result = ill * 0.5 + food * 0.1 + draccess * 0.2 + SpendsOnTreatment * 0.3;
            return result;
        }
        private static double EnMentalHealth(MentalHealthDto mentalHealth)
        {
            double mantal = 0;
            switch (mentalHealth.ProbabilityOfDealingWithMentalIllness.WhichOfTheFollowingDisordersDoYouHaveHistoryOf)
            {
                case 0:
                    mantal = 1 - 0;
                    break;
                case 1:
                    mantal = 1 - 0.9;
                    break;
                case 2:
                    mantal = 1 - 1;
                    break;
                case 3:
                    mantal = 1 - 0.9;
                    break;
                case 4:
                    mantal = 1 - 0.5;
                    break;
                case 5:
                    mantal = 1 - 0.7;
                    break;
                case 6:
                    mantal = 1 - 0.7;
                    break;
            }
            double family = 0;
            switch (mentalHealth.VisitFamilyAndFriends.HowManyTimesWeekDoYouVisitYourFamily)
            {
                case 1:
                    family = 1 / 3;
                    break;
                case 2:
                    family = 2 / 3;
                    break;
                case 3:
                    family = 3 / 3;
                    break;
            }

            var result = mantal * 0.4 + family * 0.6;
            return result;
        }
        private static double EnEnvironmental(EnvironmentalDto environmental)
        {
            double Weather = 0;
            switch (environmental.TemperatureAndWeather.WhatIsYourUnfavorableWeather)
            {
                case 0:
                    Weather = 1;
                    break;
                case 1:
                    Weather = 1 - 0.03;
                    break;
                case 2:
                    Weather = 1 - 0.21;
                    break;
                case 3:
                    Weather = 1 - 0.03;
                    break;
                case 4:
                    Weather = 1 - 0.28;
                    break;
                case 5:
                    Weather = 1 - 0.28;
                    break;
                case 6:
                    Weather = 1 - 0.17;
                    break;
            }
            double Hours = 0;
            switch (environmental.Climate.ProblemsWithDayAndNightHours)
            {
                case 0:
                    Hours = 1 - 1;
                    break;
                case 1:
                    Hours = 1 - 0;
                    break;
                case 2:
                    Hours = 2 - 0;
                    break;
                case 3:
                    Hours = 3 - 0;
                    break;
                case 4:
                    Hours = 3 - 0;
                    break;
            }

            var result = Weather * 0.67 + Hours * 0.33;
            return result;
        }
        private static double EnEducational(EducationalDto educational)
        {
            double prob = 0;
            double exp = 0;
            switch (educational.ProbabilityOfAcceptance.AcademicResume)
            {
                case 0:
                    prob = 1;
                    exp = 11541 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 1:
                    prob = 0.2;
                    exp = 25847 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 2:
                    prob = 0.5;
                    exp = 8380 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 3:
                    prob = 0.7;
                    exp = 32519 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 4:
                    prob = 0.8;
                    exp = 35465 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 5:
                    prob = 0.4;
                    exp = 24128 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 6:
                    prob = 0.9;
                    exp = 22252 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
                case 7:
                    prob = 0.8;
                    exp = 6744 / educational.Tuition.HowMuchCanYouPayPerYear;
                    break;
            }
            if (exp > 1)
            {
                exp = 1;
            }
            if (exp < 0)
            {
                exp = 0;
            }

            var result = prob * 0.3 + exp * 0.3;
            return result;
        }
        private static double EnWelfare(WelfareDto welfare)
        {
            double q;
            double x = 0;
            double a = 0;
            switch (welfare.Specialty.WhatJobDoYouWantToPursueAfterEmigrating)
            {
                case 0:
                    x = 0.7;
                    a = 12000 / welfare.Saving.HowMuchDoYouExpectToSaveAnnually;
                    break;
                case 1:
                    x = 0.8;
                    a = 10028 / welfare.Saving.HowMuchDoYouExpectToSaveAnnually;
                    break;
                case 2:
                    x = 0.2;
                    a = 9607 / welfare.Saving.HowMuchDoYouExpectToSaveAnnually;
                    break;
                case 3:
                    x = 0.5;
                    a = 10569 / welfare.Saving.HowMuchDoYouExpectToSaveAnnually;
                    break;
            }
            if (a > 1)
            {
                a = 1;
            }
            if (a < 0)
            {
                a = 0;
            }

            return x * 0.2 + a * 0.8;
        }
        private static double EnLanguage(LanguageDto model)
        {
            double lang1 = 0;
            double lang2 = 0;
            switch (model.FirstLanguageLevel)
            {
                case 0:
                    lang1 = 0;
                    break;
                case 1:
                    return 0;
                case 2:
                    return 0;
                case 3:
                    return -1;
            }
            switch (model.SecondLanguageLevel)
            {
                case 0:
                    lang2 = 0;
                    break;
                case 1:
                    return 0;
                case 2:
                    return 0;
                case 3:
                    return -1;
            }

            return (lang1 + lang2) / 2;
        }
        #endregion

    }
}