using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.AggregateModels.SharedAggregate;

namespace Telamingo.Domain.Dtos.AddCountry;

public class EnvironmentalDto
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public int ReligiousIssues { get; set; }
    public int Immigration { get; set; }
    public int SocialRelationshipMatching { get; set; }

    public List<EnvironmentalLanguageInformationDto> environmentalLanguageInformation{ get; set; } = new List<EnvironmentalLanguageInformationDto>();
}
public class EnvironmentalLanguageInformationDto
{
    public EnvironmentalLanguageInformationDto() { }
    public EnvironmentalLanguageInformationDto(EnvironmentalLanguageInformation model, Language language) 
    {
        Id = model.Id;
        EnvironmentalInformationId = model.EnvironmentalInformationId;
        LanguageId = model.LanguageId;
        Rate = model.Rate;
        EnvironmentLanguage = new EnvironmentLanguageDto(language);
    }
    public int Id { get; set; }
    public int EnvironmentalInformationId { get; set; }
    public int LanguageId { get; set; }
    public double Rate { get; set; }
    public EnvironmentLanguageDto EnvironmentLanguage { get; set; } = new EnvironmentLanguageDto();
}

public class EnvironmentLanguageDto
{
    public EnvironmentLanguageDto() { }
    public EnvironmentLanguageDto(Language language) 
    {
        Id = language.Id;
        Name = language.Name;
    }
    public int Id { get; set; }
    public string Name { get; set; }
}
