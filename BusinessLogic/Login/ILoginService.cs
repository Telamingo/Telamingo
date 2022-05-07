using BusinessLogic.Login.Dto;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic.Login
{
    public interface ILoginService
    {
        Task<string> GetAsync(LoginDto model, CancellationToken cancellationToken);
    }
}