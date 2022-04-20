using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.AggregateModels.CountryAggregate
{
    public class WelfareInformation
    {
        public int CountryId { get; set; }
        public double AnnualSavingsRates { get; set; }
        public double RequiredSpecialization { get; set; }
    }
}
