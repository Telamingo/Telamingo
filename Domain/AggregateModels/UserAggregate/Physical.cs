using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregateModels.UserAggregate
{
    public class Physical
    {
        public int MedicineNeed { get; set; }
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
}
