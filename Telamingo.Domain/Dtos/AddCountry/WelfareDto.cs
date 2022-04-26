using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Dtos.AddCountry;

public class WelfareDto
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public int JobId { get; set; }
    public double AnnualSavingsRates { get; set; }
    public double RequiredSpecialization { get; set; }
}
