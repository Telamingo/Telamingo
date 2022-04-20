using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.AggregateModels.CountryAggregate
{
    public class CulturalInformation
    {
        public int CountryId { get; set; }
        public double WeatherName { get; set; }
        public double WeatherRate { get; set; }
    }
}
