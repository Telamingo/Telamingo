using Domain.AggregateModels.CountryAggregate;
using Domain.AggregateModels.SharedAggregate;
using System.Collections.Generic;

namespace Domain.Dtos.AddCountry
{
    public class MentalHealthDto
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int AbilityToVisitFamily { get; set; }

        public List<MentalHealthPossibilityOfExacerbationOfTheDisorderDto> mentalHealthPossibilityOfExacerbationOfTheDisorder { get; set; } =
            new List<MentalHealthPossibilityOfExacerbationOfTheDisorderDto>() { };
    }
    public class MentalHealthPossibilityOfExacerbationOfTheDisorderDto
    {
        public MentalHealthPossibilityOfExacerbationOfTheDisorderDto() { }
        public MentalHealthPossibilityOfExacerbationOfTheDisorderDto(MentalHealthPossibilityOfExacerbationOfTheDisorder model, Disorder disorder)
        {
            Id = model.Id;
            MentalHealthInformationId = model.MentalHealthInformationId;
            DisorderId = model.DisorderId;
            Possibility = model.Possibility;
            Disorder = new DisorderDto(disorder);
        }
        public int Id { get; set; }
        public int MentalHealthInformationId { get; set; }
        public int DisorderId { get; set; }
        public double Possibility { get; set; }
        public DisorderDto Disorder { get; set; } = new DisorderDto();
    }
    public class DisorderDto
    {
        public DisorderDto() { }
        public DisorderDto(Disorder disorder)
        {
            Id = disorder.Id;
            Name = disorder.Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}