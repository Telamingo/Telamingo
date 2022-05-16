using Domain.AggregateModels.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.User
{
    public class UserAnswerDto
    {
        public UserInformationDto UserInformation { get; set; } = new UserInformationDto();
        public CulturalDto Cultural { get; set; } = new CulturalDto();
        public EconomyDto Economy { get; set; } = new EconomyDto();
        public EnvironmentalDto Environmental { get; set; } = new EnvironmentalDto();
        public MentalDto Mental { get; set; } = new MentalDto();
        public MostImportantsDto MostImportants { get; set; } = new MostImportantsDto();
        public PhysicalDto Physical { get; set; } = new PhysicalDto();
        public PrimaryDto Primary { get; set; } = new PrimaryDto();

    }
}
