using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Domain.AggregateModels.UserAggregate
{
    public class Economy : Entity
    {
        public int UserAnswerId { get; set; }
        public virtual UserAnswer UserAnswer { get; set; }

        public string CurrentJob { get; set; }
        public string CurrentSaving { get; set; }
        public string PreferredJob { get; set; }
        public string PreferredSaving { get; set; }
    }
}
