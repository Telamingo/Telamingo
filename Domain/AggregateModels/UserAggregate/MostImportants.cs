using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregateModels.UserAggregate
{
    public class MostImportants : Entity
    {
        public string FirstProblem { get; set; }
        public string SecendProblem { get; set; }
    }
}
