using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telamingo.Domain.SeedWork;

namespace Domain.AggregateModels.UserAggregate
{
    public class MostImportants : Entity
    {
        public string FirstProblem { get; set; }
        public string SecendProblem { get; set; }
    }
}
