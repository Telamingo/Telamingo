using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.UserAggregate
{
    public class Mental: Entity
    {
        public int UserAnswerId { get; set; }
        public virtual UserAnswer UserAnswer { get; set; }

        public bool MentalIll { get; set; }
        public string First { get; set; }
        public string Secend{ get; set; }
        public string Third { get; set; }
        public int FamilyVisit { get; set; }
    }
}
