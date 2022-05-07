using Domain.SeedWork;
using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class MediatorExtension
    {
        public static async Task<int> DispatchDomainEventsAsync(this IMediator mediator, TelamingoDbContext ctx, CancellationToken cancellationToken)
        {
            IEnumerable<EntityEntry<Entity>> domainEntities = ctx.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any());

            List<INotification> domainEvents = domainEntities
                .SelectMany(x => x.Entity.DomainEvents)
                .ToList();

            domainEntities.ToList()
                .ForEach(entity => entity.Entity.ClearDomainEvents());

            foreach (INotification domainEvent in domainEvents)
                await mediator.Publish(domainEvent, cancellationToken);
            return domainEvents.Count;
        }
    }
}