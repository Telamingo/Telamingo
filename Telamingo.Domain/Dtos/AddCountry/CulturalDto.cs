using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Dtos.AddCountry
{
    public class CulturalDto
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public List<CulturalClimateDto> CulturalClimate { get; set; }
        public List<CulturalWeatherDto> CulturalWeather { get; set; }
    }


    public class CulturalClimateDto
    {
        public int Id { get; set; }
        public int ClimateId { get; set; }
        public int CulturalInformationId { get; set; }
        public double Rate { get; set; }
    }
    public class CulturalWeatherDto
    {
        public int Id { get; set; }
        public int WeatherId { get; set; }
        public int CulturalInformationId { get; set; }
        public double Rate { get; set; }
    }
}
