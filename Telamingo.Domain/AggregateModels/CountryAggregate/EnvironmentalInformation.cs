﻿using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.CountryAggregate
{
    public class EnvironmentalInformation: Entity
    {
        public int CountryId { get; set; }
        public double ReligiousIssues { get; set; }
        public double Immigration { get; set; }
        public double SocialRelationshipMatching { get; set; }
    }
}
