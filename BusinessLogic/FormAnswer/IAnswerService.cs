using Domain.AggregateModels.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.FormAnswer
{
    public interface IAnswerService
    {
        Task AddAsync(UserAnwer model);
    }
}
