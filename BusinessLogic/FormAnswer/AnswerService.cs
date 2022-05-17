using Domain.AggregateModels.UserAggregate;
using Domain.Dtos.User;
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
        public async Task AddAsync(UserAnswerDto model)
        {
            try
            {
                await userRepository.AddUserAnswerAsync(new UserAnswer
                    (
                        new List<UserInformation>
                                {
                                                new(model.UserInformation)
                                }, new List<Cultural>
                                {
                                                new(model.Cultural)
                                }, new List<Economy>
                                {
                                                new(model.Economy)
                                }, new List<Environmental>
                                {
                                                new(model.Environmental)
                                }, new List<Mental>
                                {
                                                new(model.Mental)
                                }, new List<MostImportants>
                                {
                                                new(model.MostImportants)
                                }, new List<Physical>
                                {
                                                new(model.Physical)
                                }, new List<Primary>
                                {
                                                new(model.Primary)
                                }
                    ));

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
