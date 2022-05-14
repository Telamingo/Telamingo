using Domain.AggregateModels.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.FormAnswer
{
    public class AnswerService: IAnswerService
    {
        private readonly IUserRepository userRepository;
        public AnswerService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task AddAsync(UserAnswer model)
        {
            await userRepository.AddUserAnswerAsync(model);
        }
    }
}
