﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.UserAggregate
{
    public class Cultural: Entity
    {
        public int UserAnswerId { get; set; }
        public virtual UserAnswer UserAnswer{ get; set; }

        public int ReligiousMatters { get; set; }
        public bool NationalMatters { get; set; }
        public int IfYesHowMuch { get; set; }
        public int ImmigrantCommunity { get; set; }
        public int Similarity { get; set; }
    }
}