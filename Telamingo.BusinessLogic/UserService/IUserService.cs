using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telamingo.Domain.AggregateModels.UserAggregate;
using Telamingo.Domain.Dtos.User;

namespace Telamingo.BusinessLogic.UserService
{
    public interface IUserService
    {
        Task<List<UserInformation>> GetUserList();
        Task<UserAnswer> GetUserAnswer(int id);
    }
}
