using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Domain.AggregateModels.UserAggregate
{
    public class MostImportants : Entity
    {
        public MostImportants() { }

        public MostImportants(MostImportantsDto model)
        {
            FirstProblem = model.FirstProblem;
            SecendProblem = model.SecendProblem;
        }
        public int UserAnswerId { get; set; }
        public virtual UserAnswer UserAnswer { get; set; }

        public string FirstProblem { get; set; }
        public string SecendProblem { get; set; }
    }
    public class MostImportantsDto
    {
        public string FirstProblem { get; set; }
        public string SecendProblem { get; set; }
    }
}
