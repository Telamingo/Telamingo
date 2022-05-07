using System.Collections.Generic;

namespace Domain.Dtos.AddCountry
{
    public class AddCountryDto
    {
        public int Id { get; set; }
        public string CountryName { get; set; } = string.Empty;
        public CulturalDto Cultural { get; set; } = new CulturalDto();
        public PhysicalHealthDto PhysicalHealth { get; set; } = new PhysicalHealthDto();
        public MentalHealthDto MentalHealth { get; set; } = new MentalHealthDto();
        public EnvironmentalDto Environmental { get; set; } = new EnvironmentalDto();
        public EducationalDto Educational { get; set; } = new EducationalDto();
        //public List<LanguageDto> Language { get; set; } = new List<LanguageDto> { };
        public List<WelfareDto> Welfare { get; set; } = new List<WelfareDto>();

    }
}