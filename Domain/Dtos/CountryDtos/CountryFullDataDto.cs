namespace Domain.Dtos.CountryDtos
{
    public class CountryFullDataDto
    {
        public PersonalInformationDto PersonalInformation { get; set; }
        public CulturalDto Cultural { get; set; }
        public PhysicalHealthDto PhysicalHealth { get; set; }
        public MentalHealthDto MentalHealth { get; set; }
        public EnvironmentalDto Environmental { get; set; }
        public EducationalDto Educational { get; set; }
        public LanguageDto Language { get; set; }
        public WelfareDto Welfare { get; set; }

    }
}