using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.AggregateModels.CountryAggregate
{
    public class LanguageInformation
    {
        public int CountryId { get; set; }
        public double LanguageName { get; set; }
        public double LanguageEpidemicRates { get; set; }
    }
}
