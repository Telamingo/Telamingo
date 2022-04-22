using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class PhysicalHealthInformation: Entity
{
    public int CountryId { get; set; }
    public double StatusOfTheTreatmentSystemForSpecificDiseases { get; set; }
    //public double ProbabilityOfFindingTheDesiredFood { get; set; }
    public double DoctorAccess { get; set; }
    public double AveragePerCapitaHealthExpenditure { get; set; }

}
