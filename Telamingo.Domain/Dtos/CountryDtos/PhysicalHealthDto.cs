using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Dtos.CountryDtos
{
    public class PhysicalHealthDto
    {
        public HealthSystemForPatientsDto HealthSystemForPatients { get; set; }
        public ApplicantsFoodLifestyleDto ApplicantsFoodLifestyle { get; set; }
        public NeedToAccessDoctorDto NeedToAccessDoctor { get; set; }
        public TheApplicantExpectsTheRatioOfHealthCostsToSavingsDto HealthCostsToSavings { get; set; }
        //public TheApplicantExpectsTheRatioOfHealthCostsToSavingsDto TheApplicantExpectsTheRatioOfHealthCostsToSavings { get; set; }
    }
    public class HealthSystemForPatientsDto
    {
        public int DoYouHaveSpecificIllness { get; set; }
    }
    public class ApplicantsFoodLifestyleDto
    {
        public int Option { get; set; }
    }
    public class NeedToAccessDoctorDto
    {
        public int HowManyTimesYearDoYouOrYourFamilyUsuallySeeDoctor { get; set; }
    }
    public class TheApplicantExpectsTheRatioOfHealthCostsToSavingsDto
    {
        public int SpendsOnTreatment { get; set; }
        //public int HowMuchDoYouExpectToSpendOnYourTreatmentAndMedicalIssuesDuringTheYear { get; set; }
    }
}
