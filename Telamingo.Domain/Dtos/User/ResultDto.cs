using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Dtos.User
{
    public class ResultDto
    {
        public double Cultural { get; set; }
        public double PhysicalHealth { get; set; }
        public double MentalHealth { get; set; }
        public double Environmental { get; set; }
        public double Educational { get; set; }
        public double Welfare { get; set; }
        public double Result { get; set; }
    }
}
