using MediatR;

namespace Domain.SeedWork
{
    public interface IMediatorProvider
    {
        IMediator GetMediator();
    }
}