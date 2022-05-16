using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telamingo.Domain.AggregateModels.UserAggregate;
using Telamingo.Domain.Dtos.User;

namespace Telamingo.BusinessLogic.UserService
{
    public class UserService: IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<List<UserInformation>> GetUserList()
        {
            List<UserInformation> Result = await userRepository.GetUserList();
            return Result;
        }
        public async Task<UserAnswer> GetUserAnswer(int id)
        {
            UserAnswer Result = await userRepository.GetAnswer(id);
            return Result;
        }
    }
}
