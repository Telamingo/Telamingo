using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.UserAggregate
{
    public class Companions: Entity
    {
        public int Age { get; set; }
        public string First_Lang { get; set; }
        public string Second_Lang { get; set; }
        public string Third_Lang { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }

        public int PrimaryId { get; set; }
        public virtual Primary Primary { get; set; }

    }
}
