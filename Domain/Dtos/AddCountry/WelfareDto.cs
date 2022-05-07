using Domain.AggregateModels.SharedAggregate;

namespace Domain.Dtos.AddCountry
{
    public class WelfareDto
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int JobId { get; set; }
        public double AnnualSavingsRates { get; set; }
        public double RequiredSpecialization { get; set; }
        public string JobName { get; set; } = string.Empty;
    }
    public class JobDto
    {
        public JobDto() { }
        public JobDto(Job job)
        {
            Id = job.Id;
            Name = job.Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}