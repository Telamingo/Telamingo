using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.AggregateModels.CountryAggregate
{
    public class MentalHealthInformation
    {
        public int CountryId { get; set; }
        public double PossibilityOfExacerbationOfTheDisorder { get; set; }
        public double AbilityToVisitFamily { get; set; }
    }
}
