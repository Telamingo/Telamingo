using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregateModels.UserAggregate
{
    public class Economy
    {
        public string CurrentJob { get; set; }
        public string CurrentSaving { get; set; }
        public string PreferredJob { get; set; }
        public string PreferredSaving { get; set; }
    }
}
