using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Domain.AggregateModels.UserAggregate
{
    public class Physical : Entity
    {
        public Physical() { }

        public Physical(PhysicalDto model)
        {
            MedicineNeed = model.MedicineNeed;
            SpecialIll = model.SpecialIll;  
            First = model.First;
            Secend = model.Secend;
            Third = model.Third;
            MedicineCost = model.MedicineCost;
            SpecialFood = model.SpecialFood;
            TraditionalFood = model.TraditionalFood;    
            FastFood = model.FastFood;  
            Vegeterian = model.Vegeterian;
        }
        public int UserAnswerId { get; set; }
        public virtual UserAnswer UserAnswer { get; set; }

        public string MedicineNeed { get; set; }
        public bool SpecialIll { get; set; }
        public string First { get; set; }
        public string Secend { get; set; }
        public string Third { get; set; }
        public string MedicineCost { get; set; }
        public int SpecialFood { get; set; }
        public int TraditionalFood { get; set; }
        public int FastFood { get; set; }
        public int Vegeterian { get; set; }
    }
    public class PhysicalDto
    {
        public string? MedicineNeed { get; set; }
        public bool SpecialIll { get; set; }
        public string? First { get; set; }
        public string? Secend { get; set; }
        public string? Third { get; set; }
        public string? MedicineCost { get; set; }
        public int SpecialFood { get; set; }
        public int TraditionalFood { get; set; }
        public int FastFood { get; set; }
        public int Vegeterian { get; set; }
    }
}
