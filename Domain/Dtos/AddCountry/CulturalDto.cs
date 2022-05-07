using Domain.AggregateModels.CountryAggregate;
using Domain.AggregateModels.SharedAggregate;
using System.Collections.Generic;

namespace Domain.Dtos.AddCountry
{
    public class CulturalDto
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public List<CulturalClimateDto> CulturalClimate { get; set; } = new List<CulturalClimateDto>() { };
        public List<CulturalWeatherDto> CulturalWeather { get; set; } = new List<CulturalWeatherDto> { };
    }

    public class CulturalClimateDto
    {
        public CulturalClimateDto() { }
        public CulturalClimateDto(CulturalClimateInformation model, Climate climate)
        {
            Id = model.Id;
            ClimateId = model.ClimateId;
            CulturalInformationId = model.CulturalInformationId;
            Rate = model.Rate;
            Climate = new ClimateDto(climate);
        }
        public int Id { get; set; }
        public int ClimateId { get; set; }
        public int CulturalInformationId { get; set; }
        public double Rate { get; set; }
        public ClimateDto Climate { get; set; } = new ClimateDto();
    }
    public class ClimateDto
    {
        public ClimateDto() { }
        public ClimateDto(Climate climate)
        {
            Id = climate.Id;
            Name = climate.Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class CulturalWeatherDto
    {
        public CulturalWeatherDto() { }
        public CulturalWeatherDto(CulturalweatherInformation model, Weather weather)
        {
            Id = model.Id;
            WeatherId = model.WeatherId;
            CulturalInformationId = model.CulturalInformationId;
            Rate = model.Rate;
            Weather = new WeatherDto(weather);
        }

        public int Id { get; set; }
        public int WeatherId { get; set; }
        public int CulturalInformationId { get; set; }
        public double Rate { get; set; }
        public WeatherDto Weather { get; set; }
    }
    public class WeatherDto
    {
        public WeatherDto() { }
        public WeatherDto(Weather weather)
        {
            Id = weather.Id;
            Name = weather.Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}