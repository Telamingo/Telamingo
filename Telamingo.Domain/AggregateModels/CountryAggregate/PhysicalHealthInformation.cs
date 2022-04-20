using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.AggregateModels.CountryAggregate
{
    public class PhysicalHealthInformation
    {
        public int CountryId { get; set; }
        public double StatusOfTheTreatmentSystemForSpecificDiseases { get; set; }
        public double ProbabilityOfFindingTheDesiredFood { get; set; }
        public double DoctorAccess { get; set; }
        public double AveragePerCapitaHealthExpenditure { get; set; }

    }
}
