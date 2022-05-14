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
        public UserInformation UserInformation { get; set; } = new UserInformation();
        public Cultural Cultural { get; set; } = new Cultural();
        public Economy Economy { get; set; } = new Economy();
        public Environmental Environmental { get; set; } = new Environmental();
        public Mental Mental { get; set; } = new Mental();
        public MostImportants MostImportants { get; set; } = new MostImportants();
        public Physical Physical { get; set; } = new Physical();
        public Primary Primary { get; set; } = new Primary();

    }
}
