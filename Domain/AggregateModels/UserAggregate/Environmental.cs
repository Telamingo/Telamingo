using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Domain.AggregateModels.UserAggregate
{
    public class Environmental : Entity
    {
        public Environmental() { }
        public Environmental(EnvironmentalDto model)
        {
            SpecialWeather = model.SpecialWeather;
            Cloudy = model.Cloudy;
            Snowy = model.Snowy;
            Sunny = model.Sunny;
            Moderate = model.Moderate;
            UnusualDaytime = model.UnusualDaytime;
        }
        public int UserAnswerId { get; set; }
        public virtual UserAnswer UserAnswer { get; set; }

        public bool SpecialWeather { get; set; }
        public int Cloudy { get; set; }
        public int Snowy { get; set; }
        public int Sunny { get; set; }
        public int Moderate { get; set; }
        public int UnusualDaytime { get; set; }
    }
    public class EnvironmentalDto
    {
        public bool SpecialWeather { get; set; }
        public int Cloudy { get; set; }
        public int Snowy { get; set; }
        public int Sunny { get; set; }
        public int Moderate { get; set; }
        public int UnusualDaytime { get; set; }
    }
}
