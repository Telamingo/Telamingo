using Domain.AggregateModels.CountryAggregate;
using Domain.AggregateModels.SharedAggregate;

namespace Domain.Dtos.AddCountry;

public class PhysicalHealthDto
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public double StatusOfTheTreatmentSystemForSpecificDiseases { get; set; }
    public int DoctorAccess { get; set; }
    public double AveragePerCapitaHealthExpenditure { get; set; }

    public List<PhysicalHealthDesiredFoodDto> PhysicalHealthDesiredFood { get; set; } = new List<PhysicalHealthDesiredFoodDto>() { };
}
public class PhysicalHealthDesiredFoodDto
{
    public PhysicalHealthDesiredFoodDto() { }
    public PhysicalHealthDesiredFoodDto(PhysicalHealthDesiredFood model, Food food)
    {
        Id = model.Id;
        FoodId = model.FoodId;
        PhysicalHealthInformationId = model.PhysicalHealthInformationId;
        Rate = model.Rate;
        Food = new FoodDto(food);
    }
    public int Id { get; set; }
    public int FoodId { get; set; }
    public int PhysicalHealthInformationId { get; set; }
    public double Rate { get; set; }
    public FoodDto Food { get; set; } = new FoodDto();
}
public class FoodDto
{
    public FoodDto() { }
    public FoodDto(Food food)
    {
        Id = food.Id;
        Name = food.Name;
    }
    public int Id { get; set; }
    public string Name { get; set; }
}
