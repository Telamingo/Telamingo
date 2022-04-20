namespace Telamingo.Domain.SeedWork
{
    public interface IRepository<T> where T : IAggregate
    {
        IUnitOfWork UnitOfWork { get; }
    }
}