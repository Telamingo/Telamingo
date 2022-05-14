using Domain.SeedWork;
using System.Collections.Generic;

namespace Domain.AggregateModels.UserAggregate
{
    public class UserAnswer : Entity
    {
        public UserInformation UserInformation { get; set; } = new UserInformation();
        public Cultural Cultural { get; set; } = new Cultural();
        public Economy Economy { get; set; } = new Economy();
        public Environmental Environmental { get; set; } = new Environmental();
        public Mental Mental { get; set; } = new Mental();
        public MostImportants MostImportants { get; set; } = new MostImportants();
        public Physical Physical { get; set; } = new Physical();
        public Primary Primary { get; set; } = new Primary();

        public IReadOnlyCollection<UserInformation> UserInformations => _userInformation;
        private readonly List<UserInformation> _userInformation;
        public IReadOnlyCollection<Cultural> Culturals => _cultural;
        private readonly List<Cultural> _cultural;
        public IReadOnlyCollection<Economy> Economys => _economy;
        private readonly List<Economy> _economy;
        public IReadOnlyCollection<Environmental> Environmentals => _environmental;
        private readonly List<Environmental> _environmental;
        public IReadOnlyCollection<Mental> Mentals => _mental;
        private readonly List<Mental> _mental;
        public IReadOnlyCollection<MostImportants> MostImportantss => _mostImportants;
        private readonly List<MostImportants> _mostImportants;
        public IReadOnlyCollection<Physical> Physicals => _physical;
        private readonly List<Physical> _physical;
        public IReadOnlyCollection<Primary> Primarys => _primary;
        private readonly List<Primary> _primary;

    }
}
