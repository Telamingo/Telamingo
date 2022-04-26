namespace Telamingo.Domain.Dtos.AddCountry;

public class AddCountryDto
{
    public int Id { get; set; }
    public string CountryName { get; set; }

    //public PersonalInformationDto PersonalInformation { get; set; }

    public CulturalDto Cultural { get; set; }
    public PhysicalHealthDto PhysicalHealth { get; set; }
    public MentalHealthDto MentalHealth { get; set; }
    public EnvironmentalDto Environmental { get; set; }
    public EducationalDto Educational { get; set; }
    public List<LanguageDto> Language { get; set; }
    public WelfareDto Welfare { get; set; }

}
