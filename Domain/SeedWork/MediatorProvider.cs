using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.SeedWork
{
    public class MediatorProvider : IMediatorProvider
    {
        private readonly IServiceProvider _serviceProvider;

        public MediatorProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IMediator GetMediator()
        {
            IServiceScope scope = _serviceProvider.CreateScope();
            return (IMediator)scope.ServiceProvider.GetService(typeof(IMediator));
        }
    }
}