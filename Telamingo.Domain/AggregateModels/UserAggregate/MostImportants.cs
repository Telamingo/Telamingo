using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.UserAggregate
{
    public class MostImportants: Entity
    {
        public int UserAnswerId { get; set; }
        public virtual UserAnswer UserAnswer { get; set; }

        public string FirstProblem { get; set; }
        public string SecendProblem { get; set; }
    }
}
