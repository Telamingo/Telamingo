using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.CountryDtos
{
    public class EnvironmentalDto
    {
        public TemperatureAndWeatherDto TemperatureAndWeather { get; set; }
        public ClimateDto Climate { get; set; }
    }
    public class TemperatureAndWeatherDto
    {
        public int WhatIsYourUnfavorableWeather { get; set; }
    }
    public class ClimateDto
    {
        public int ProblemsWithDayAndNightHours { get; set; }
    }
}
