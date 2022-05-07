using Infrastructure.EntityConfigurations;
using MediatR;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Domain.AggregateModels.AdminAggregate;
using Domain.AggregateModels.UserAggregate;
using Domain.SeedWork;
using Infrastructure.EntityConfigurations.UserEntityConfigurations;
using Infrastructure.EntityConfigurations.AdminEntityConfigurations;
using Domain.AggregateModels.CountryAggregate;
using Infrastructure.EntityConfigurations.CountryEntityConfigurations;
using Domain.AggregateModels.SharedAggregate;
using Infrastructure.EntityConfigurations.SharedEntityConfigurations;
using System;
using System.Threading.Tasks;
using System.Threading;

namespace Infrastructure
{
    public class TelamingoDbContext : DbContext, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "dbo";

        #region Db sets

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminRole> AdminRoles { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<CulturalClimateInformation> CulturalClimateInformations { get; set; }
        public DbSet<CulturalInformation> CulturalInformations { get; set; }
        public DbSet<CulturalweatherInformation> CulturalweatherInformations { get; set; }
        public DbSet<EducationalInformation> EducationalInformations { get; set; }
        public DbSet<EducationalInformationTuition> EducationalInformationTuitions { get; set; }
        public DbSet<EducationalProbabilityOfAcceptance> EducationalProbabilityOfAcceptances { get; set; }
        public DbSet<EnvironmentalInformation> EnvironmentalInformations { get; set; }
        public DbSet<EnvironmentalLanguageInformation> EnvironmentalLanguageInformations { get; set; }
        public DbSet<LanguageInformation> LanguageInformations { get; set; }
        public DbSet<MentalHealthInformation> MentalHealthInformations { get; set; }
        public DbSet<MentalHealthPossibilityOfExacerbationOfTheDisorder> MentalHealthPossibilityOfExacerbationOfTheDisorders { get; set; }
        public DbSet<PhysicalHealthDesiredFood> PhysicalHealthDesiredFoods { get; set; }
        public DbSet<PhysicalHealthInformation> PhysicalHealthInformations { get; set; }
        public DbSet<WelfareInformation> WelfareInformation { get; set; }
        public DbSet<Climate> Climates { get; set; }
        public DbSet<Disorder> Disorders { get; set; }
        public DbSet<FildOfStudy> FildOfStudies { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Weather> Weathers { get; set; }

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
            modelBuilder.ApplyConfiguration(new AdminEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AdminRoleEntityTypeConfiguration());

            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CountryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CulturalClimateInformationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CulturalInformationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CulturalWeatherInformationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EducationalInformationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EducationalInformationTuitionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EducationalProbabilityOfAcceptanceEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EnvironmantalInformationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EnvironmentalLanguageInformationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageInformationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MentalHealthInformationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MentalHealthPossibilityOfExacerbationOfTheDisorderEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PhysicalHealthDesiredFoodEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PhysicalHealthInformationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WelfareInformationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ClimateEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DisorderEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FildOfStudyEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FoodEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JobEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WeatherEntityTypeConfiguration());

        }
        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
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
            int result = await base.SaveChangesAsync(cancellationToken) + eventCount;

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
}