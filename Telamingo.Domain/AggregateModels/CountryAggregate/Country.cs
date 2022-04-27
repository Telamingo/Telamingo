using Telamingo.Domain.Dtos.AddCountry;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public class Country : Entity
{
    public Country()
    {

    }
    public Country(AddCountryDto model)
    {
        Name = model.CountryName;
        //_welfareInformation.AddRange(model.Welfare);
    }
    public string Name { get; set; }

    public IReadOnlyCollection<WelfareInformation> welfareInformation => _welfareInformation;
    private readonly List<WelfareInformation> _welfareInformation;

    public IReadOnlyCollection<PhysicalHealthInformation> PhysicalHealthInformation => _PhysicalHealthInformation;
    private readonly List<PhysicalHealthInformation> _PhysicalHealthInformation;

    public IReadOnlyCollection<LanguageInformation> languageInformation => _languageInformation;
    private readonly List<LanguageInformation> _languageInformation;

    public IReadOnlyCollection<EnvironmentalInformation> environmentalInformation => _environmentalInformation;
    private readonly List<EnvironmentalInformation> _environmentalInformation;
    public IReadOnlyCollection<EducationalInformation> educationalInformation => _educationalInformation;
    private readonly List<EducationalInformation> _educationalInformation;

    public IReadOnlyCollection<CulturalInformation> culturalInformation => _culturalInformation;
    private readonly List<CulturalInformation> _culturalInformation;

    public IReadOnlyCollection<MentalHealthInformation>  mentalHealthInformation => _mentalHealthInformation;
    private readonly List<MentalHealthInformation> _mentalHealthInformation;


}
