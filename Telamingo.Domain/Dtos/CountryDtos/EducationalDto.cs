using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Dtos.CountryDtos
{
    public class EducationalDto
    {
        public TuitionDto Tuition { get; set; }
        public ProbabilityOfAcceptanceDto ProbabilityOfAcceptance { get; set; }
    }
    public class TuitionDto
    {
        public int HowMuchCanYouPayPerYear { get; set; }
    }
    public class ProbabilityOfAcceptanceDto
    {
        public int AcademicResume { get; set; }
    }
}
