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
        public UserInformationDto UserInformation { get; set; }
        public CulturalDto Cultural { get; set; }
        public EconomyDto Economy { get; set; }
        public EnvironmentalDto Environmental { get; set; } 
        public MentalDto Mental { get; set; }
        public MostImportantsDto MostImportants { get; set; }
        public PhysicalDto Physical { get; set; }
        public PrimaryDto Primary { get; set; }

    }
}
