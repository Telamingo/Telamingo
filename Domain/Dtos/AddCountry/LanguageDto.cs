namespace Domain.Dtos.AddCountry;

public class LanguageDto
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public string LanguageName { get; set; }
    public double LanguageEpidemicRates { get; set; }
}
