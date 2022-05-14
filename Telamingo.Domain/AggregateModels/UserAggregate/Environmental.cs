using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.UserAggregate
{
    public class Environmental: Entity
    {
        public bool SpecialWeather { get; set; }
        public int Cloudy { get; set; }
        public int Snowy { get; set; }
        public int Sunny { get; set; }
        public int Moderate { get; set; }
        public int UnusualDaytime { get; set; }
    }
}
