using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.UserAggregate
{
    public class UserAnwer: Entity
    {
        public UserInformation UserInformation{ get; set; }
        public Cultural Cultural{ get; set; }
        public Economy Economy{ get; set; }
        public Environmental Environmental{ get; set; }
        public Mental Mental{ get; set; }
        public MostImportants MostImportants{ get; set; }
        public Physical Physical{ get; set; }
        public Primary Primary{ get; set; }
    }
}
