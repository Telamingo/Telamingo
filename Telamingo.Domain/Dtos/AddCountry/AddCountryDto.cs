namespace Telamingo.Domain.Dtos.AddCountry;

public class AddCountryDto
{
    public int Id { get; set; }
    public string CountryName { get; set; }

    //public PersonalInformationDto PersonalInformation { get; set; }

    public CulturalDto Cultural { get; set; } = new CulturalDto();
    public PhysicalHealthDto PhysicalHealth { get; set; }= new PhysicalHealthDto();
    public MentalHealthDto MentalHealth { get; set; } = new MentalHealthDto();
    public EnvironmentalDto Environmental { get; set; } = new EnvironmentalDto();
    public EducationalDto Educational { get; set; } = new EducationalDto();
    public List<LanguageDto> Language { get; set; } = new List<LanguageDto> { };
    public WelfareDto Welfare { get; set; } = new WelfareDto();

}
