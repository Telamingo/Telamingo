using Telamingo.Domain.AggregateModels.UserAggregate;
using Telamingo.Domain.SeedWork;
using Telamingo.Infrastructure.EntityConfigurations;
using MediatR;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using Telamingo.Domain.AggregateModels.AdminAggregate;
using Microsoft.EntityFrameworkCore;
using Telamingo.Infrastructure.EntityConfigurations.UserEntityConfigurations;
using Telamingo.Infrastructure.EntityConfigurations.AdminEntityConfigurations;

namespace Telamingo.Infrastructure;

public class TelamingoDbContext : DbContext, IUnitOfWork
{
    public const string DEFAULT_SCHEMA = "dbo";

    #region Db sets

    public DbSet<User> Users { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<AdminRole> AdminRoles { get; set; }

    #endregion

    private readonly IMediator _mediator;
    private IDbContextTransaction _currentTransaction;

    public TelamingoDbContext(DbContextOptions<TelamingoDbContext> options) : base(options) { }

    public IDbContextTransaction GetCurrentTransaction() => _currentTransaction;

    public bool HasActiveTransaction => _currentTransaction != null;
    public TelamingoDbContext(DbContextOptions<TelamingoDbContext> options, IMediator mediator) : base(options)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));


        System.Diagnostics.Debug.WriteLine("TelamingoDbContext::ctor ->" + GetHashCode());
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new AdminEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new AdminRoleEntityTypeConfiguration());
    }
    public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        // Dispatch Domain Events collection. 
        // Choices:
        // A) Right BEFORE committing data (EF SaveChanges) into the DB will make a single transaction including  
        // side effects from the domain event handlers which are using the same DbContext with "InstancePerLifetimeScope" or "scoped" lifetime
        // B) Right AFTER committing data (EF SaveChanges) into the DB will make multiple transactions. 
        // You will need to handle eventual consistency and compensatory actions in case of failures in any of the Handlers. 
        int eventCount = await _mediator.DispatchDomainEventsAsync(this, cancellationToken);

        // After executing this line all the changes (from the Command Handler and Domain Event Handlers) 
        // performed through the DbContext will be committed
        int result = (await base.SaveChangesAsync(cancellationToken) + eventCount);

        return result > 0;
    }

    public async Task<IDbContextTransaction> BeginTransactionAsync()
    {
        if (_currentTransaction != null) return null;

        _currentTransaction = await Database.BeginTransactionAsync(IsolationLevel.ReadCommitted);

        return _currentTransaction;
    }

    public async Task CommitTransactionAsync(IDbContextTransaction transaction)
    {
        if (transaction == null) throw new ArgumentNullException(nameof(transaction));
        if (transaction != _currentTransaction) throw new InvalidOperationException($"Transaction {transaction.TransactionId} is not current");

        try
        {
            await SaveChangesAsync();
            await transaction.CommitAsync();
        }
        catch
        {
            RollbackTransaction();
            throw;
        }
        finally
        {
            if (_currentTransaction != null)
            {
                _currentTransaction.Dispose();
                _currentTransaction = null;
            }
        }
    }

    public void RollbackTransaction()
    {
        try
        {
            _currentTransaction?.Rollback();
        }
        finally
        {
            if (_currentTransaction != null)
            {
                _currentTransaction.Dispose();
                _currentTransaction = null;
            }
        }
    }
}
