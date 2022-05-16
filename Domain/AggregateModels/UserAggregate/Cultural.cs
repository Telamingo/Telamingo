using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Domain.AggregateModels.UserAggregate
{
    public class Cultural : Entity
    {
        public Cultural() { }
        public Cultural(CulturalDto model)
        {
            ReligiousMatters = model.ReligiousMatters;
            NationalMatters = model.NationalMatters == 1 ? true : false;
            IfYesHowMuch = model.IfYesHowMuch;
            ImmigrantCommunity = model.ImmigrantCommunity;
            Similarity = model.Similarity;
        }
        public int UserAnswerId { get; set; }
        public virtual UserAnswer UserAnswer { get; set; }

        public int ReligiousMatters { get; set; }
        public bool NationalMatters { get; set; }
        public int IfYesHowMuch { get; set; }
        public int ImmigrantCommunity { get; set; }
        public int Similarity { get; set; }
    }
    public class CulturalDto
    {
        public int ReligiousMatters { get; set; }
        public int NationalMatters { get; set; }
        public int IfYesHowMuch { get; set; }
        public int ImmigrantCommunity { get; set; }
        public int Similarity { get; set; }
    }

}
