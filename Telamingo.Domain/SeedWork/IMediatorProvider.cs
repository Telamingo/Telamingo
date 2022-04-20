using MediatR;

namespace Telamingo.Domain.SeedWork
{
    public interface IMediatorProvider
    {
        IMediator GetMediator();
    }
}