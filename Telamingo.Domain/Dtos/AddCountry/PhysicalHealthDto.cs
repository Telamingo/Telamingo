using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Dtos.AddCountry;

public class PhysicalHealthDto
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public double StatusOfTheTreatmentSystemForSpecificDiseases { get; set; }
    public int DoctorAccess { get; set; }
    public double AveragePerCapitaHealthExpenditure { get; set; }

    public List<PhysicalHealthDesiredFoodDto> physicalHealthDesiredFood { get; set; }
}
public class PhysicalHealthDesiredFoodDto
{
    public int Id { get; set; }
    public int FoodId { get; set; }
    public int PhysicalHealthInformationId { get; set; }
    public double Rate { get; set; }
}
