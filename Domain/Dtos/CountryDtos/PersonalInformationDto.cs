namespace Domain.Dtos.CountryDtos
{
    public class PersonalInformationDto
    {
        public int? Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int CurentCuntry { get; set; }
        public int MigrationType { get; set; }
        public int TargetCuntry { get; set; }
        public int FieldOfStudy { get; set; }
        public double Grade { get; set; }
        public int University { get; set; }
        public double LastGradePointAverage { get; set; }
        public int CurentCity { get; set; }
        public int WorkExperience { get; set; }
        public string FinancialSituation { get; set; } = string.Empty;
    }
}