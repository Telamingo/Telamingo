using Domain.SeedWork;
using System.Collections.Generic;

namespace Domain.AggregateModels.CountryAggregate
{
    public class PhysicalHealthInformation : Entity
    {
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public double StatusOfTheTreatmentSystemForSpecificDiseases { get; set; }
        public int DoctorAccess { get; set; }
        public double AveragePerCapitaHealthExpenditure { get; set; }

        public IReadOnlyCollection<PhysicalHealthDesiredFood> physicalHealthDesiredFoods => _physicalHealthDesiredFoods;
        private readonly List<PhysicalHealthDesiredFood> _physicalHealthDesiredFoods;

    }
}