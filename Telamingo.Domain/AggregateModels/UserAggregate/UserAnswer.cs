using Telamingo.Domain.SeedWork;

namespace Telamingo.Domain.AggregateModels.UserAggregate
{
    public class UserAnswer: Entity
    {
        public UserAnswer()
        {
            _userInformation = new List<UserInformation>();
            _cultural = new List<Cultural>();
            _economy = new List<Economy>();
            _environmental = new List<Environmental>();
            _mental = new List<Mental>();
            _mostImportants = new List<MostImportants>();
            _physical = new List<Physical>();
            _primary = new List<Primary>();
        }
        public UserAnswer(List<UserInformation> userInformation, List<Cultural> culturals, List<Economy> economies, List<Environmental> environmentals,
            List<Mental> mentals, List<MostImportants> mostImportants, List<Physical> physicals, List<Primary> primaries)
        {
            _userInformation = userInformation;
            _cultural = culturals;
            _economy = economies;
            _environmental = environmentals;
            _mental = mentals;
            _mostImportants = mostImportants;
            _physical = physicals;
            _primary = primaries;
        }

        public UserInformation UserInformation { get; set; }
        public Cultural Cultural { get; set; }
        public Economy Economy { get; set; }
        public Environmental Environmental { get; set; }
        public Mental Mental { get; set; }
        public MostImportants MostImportants { get; set; }
        public Physical Physical { get; set; }
        public Primary Primary { get; set; }

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
