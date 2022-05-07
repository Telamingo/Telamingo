using Domain.AggregateModels.CountryAggregate;
using Domain.AggregateModels.SharedAggregate;
using System.Collections.Generic;

namespace Domain.Dtos.AddCountry
{
    public class EducationalDto
    {
        public int Id { get; set; }
        public int CountryId { get; set; }

        public List<TuitionDto> Tuition { get; set; } = new List<TuitionDto>();
        public List<ProbabilityOfAcceptanceDto> ProbabilityOfAcceptance { get; set; } = new List<ProbabilityOfAcceptanceDto>();
    }
    public class TuitionDto
    {
        public TuitionDto() { }
        public TuitionDto(EducationalInformationTuition model, FildOfStudy fildOfStudy)
        {
            Id = model.Id;
            EducationalInformationId = model.EducationalInformationId;
            FildOfStudyId = model.FildOfStudyId;
            Price = model.Price;
            FildOfStudy = new FildOfStudyDto(fildOfStudy);
        }
        public int Id { get; set; }
        public int EducationalInformationId { get; set; }
        public int FildOfStudyId { get; set; }
        public double Price { get; set; }
        public FildOfStudyDto FildOfStudy { get; set; } = new FildOfStudyDto();
    }
    public class ProbabilityOfAcceptanceDto
    {
        public ProbabilityOfAcceptanceDto() { }
        public ProbabilityOfAcceptanceDto(EducationalProbabilityOfAcceptance model, FildOfStudy fildOfStudy)
        {
            Id = model.Id;
            EducationalInformationId = model.EducationalInformationId;
            FildOfStudyId = model.FildOfStudyId;
            Rate = model.Rate;
            FildOfStudy = new FildOfStudyDto(fildOfStudy);
        }
        public int Id { get; set; }
        public int EducationalInformationId { get; set; }
        public int FildOfStudyId { get; set; }
        public double Rate { get; set; }
        public FildOfStudyDto FildOfStudy { get; set; } = new FildOfStudyDto();
    }

    public class FildOfStudyDto
    {
        public FildOfStudyDto() { }
        public FildOfStudyDto(FildOfStudy fildOfStudy)
        {
            Id = fildOfStudy.Id;
            Name = fildOfStudy.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}