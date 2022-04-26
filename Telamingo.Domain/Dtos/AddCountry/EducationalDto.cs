using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Dtos.AddCountry;

public class EducationalDto
{
    public int Id { get; set; }
    public int CountryId { get; set; }

    public List<TuitionDto> Tuition { get; set; }
    public List<ProbabilityOfAcceptanceDto> ProbabilityOfAcceptance { get; set; }
}
public class TuitionDto
{
    public int Id { get; set; }
    public int EducationalInformationId { get; set; }
    public int FildOfStudyId { get; set; }
    public double Price { get; set; }
}
public class ProbabilityOfAcceptanceDto
{
    public int Id { get; set; }
    public int EducationalInformationId { get; set; }
    public int FildOfStudyId { get; set; }
    public double Rate { get; set; }
}

