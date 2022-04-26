using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Dtos.AddCountry;

public class MentalHealthDto
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public int AbilityToVisitFamily { get; set; }

    public List<MentalHealthPossibilityOfExacerbationOfTheDisorderDto> mentalHealthPossibilityOfExacerbationOfTheDisorder{ get; set; }
}
public class MentalHealthPossibilityOfExacerbationOfTheDisorderDto
{
    public int Id { get; set; }
    public int MentalHealthInformationId { get; set; }
    public int DisorderId { get; set; }
    public double Possibility { get; set; }

}
