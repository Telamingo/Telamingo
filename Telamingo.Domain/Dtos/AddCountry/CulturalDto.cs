﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.AggregateModels.SharedAggregate;

namespace Telamingo.Domain.Dtos.AddCountry
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
        public CulturalClimateDto()
        {

        }
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
        public int Id { get; set; }
        public int WeatherId { get; set; }
        public int CulturalInformationId { get; set; }
        public double Rate { get; set; }
    }
}
