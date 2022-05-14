using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregateModels.UserAggregate
{
    public class Cultural
    {
        public int ReligiousMatters { get; set; }
        public bool NationalMatters { get; set; }
        public int IfYesHowMuch { get; set; }
        public int ImmigrantCommunity { get; set; }
        public int Similarity { get; set; }
    }
}
