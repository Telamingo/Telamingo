using Domain.SeedWork;

namespace Domain.AggregateModels.CountryAggregate;

public class CulturalInformation : Entity
{
    public int CountryId { get; set; }
    public virtual Country Country { get; set; }


    public IReadOnlyCollection<CulturalweatherInformation> culturalweatherInformation => _culturalweatherInformation;
    private readonly List<CulturalweatherInformation> _culturalweatherInformation;

    public IReadOnlyCollection<CulturalClimateInformation> culturalClimateInformation => _culturalClimateInformation;
    private readonly List<CulturalClimateInformation> _culturalClimateInformation;

    //public double WeatherName { get; set; }
    //public double WeatherRate { get; set; }
}
