using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Domain.AggregateModels.UserAggregate
{
    public class Primary : Entity
    {
        public Primary() { }

        public Primary(PrimaryDto model)
        {
            User_Destination = model.User_Destination;
            Preferred_Visa_Type = model.Preferred_Visa_Type;
            Age = model.Age;
            Sex = model.Sex;
            First_Lang = model.First_Lang;
            First_LangLevel = model.First_LangLevel;
            Second_Lang = model.Second_Lang;
            Second_LangLevel = model.Second_LangLevel;
            Third_Lang = model.Third_Lang;
            Third_LangLevel = model.Third_LangLevel;
            MaritalStatus = model.MaritalStatus;
            NumberOfCompanions = model.NumberOfCompanions;
        }
        public int UserAnswerId { get; set; }
        public virtual UserAnswer UserAnswer { get; set; }

        public string User_Destination { get; set; }
        public string Preferred_Visa_Type { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string First_Lang { get; set; }
        public string First_LangLevel { get; set; }
        public string Second_Lang { get; set; }
        public string Second_LangLevel { get; set; }
        public string Third_Lang { get; set; }
        public string Third_LangLevel { get; set; }
        public string MaritalStatus { get; set; }
        public int NumberOfCompanions { get; set; }

        public IReadOnlyCollection<Companions> Companions => _companions;
        private readonly List<Companions> _companions;
    }
    public class PrimaryDto
    {
        public string User_Destination { get; set; }
        public string Preferred_Visa_Type { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string First_Lang { get; set; }
        public string First_LangLevel { get; set; }
        public string Second_Lang { get; set; }
        public string Second_LangLevel { get; set; }
        public string Third_Lang { get; set; }
        public string Third_LangLevel { get; set; }
        public string MaritalStatus { get; set; }
        public int NumberOfCompanions { get; set; }
    }
}
