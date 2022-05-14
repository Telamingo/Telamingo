using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregateModels.UserAggregate
{
    public class Primary
    {
        public string User_Destination { get; set; }
        public string Preferred_Visa_Type { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string First_Lang { get; set; }
        public int Level { get; set; }
        public string Second_Lang { get; set; }
        public int Second_LangLevel { get; set; }
        public string Third_Lang { get; set; }
        public int Third_LangLevel { get; set; }
        public bool Marriage { get; set; }
        public int NumberOfCompanions { get; set; }
        public List<Companions> Companions { get; set; }
    }
    public class Companions
    {
        public int Age { get; set; }
        public string First_Lang { get; set; }
        public string Second_Lang { get; set; }
        public string Third_Lang { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }
    }
}
