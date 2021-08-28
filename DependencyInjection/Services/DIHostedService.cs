using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class DIHostedService : IHostedService
    {
        public IServiceProvider _serviceProvider;
        public DIHostedService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            using(var scope = _serviceProvider.CreateScope())
            {
                var SingletonService = scope.ServiceProvider.GetRequiredService<ISingletonService>();
                var ScopedService = scope.ServiceProvider.GetRequiredService<IScopedService>();
                var TraisientService = scope.ServiceProvider.GetRequiredService<ITraisientService>();

                Debug.WriteLine("The Singleton Time is {0}", SingletonService.Time);
                Debug.WriteLine("The Scope Time is {0}", ScopedService.Time);
                Debug.WriteLine("The Traisient Time is {0}", TraisientService.Time);
            }
            
            using(var scope = _serviceProvider.CreateScope())
            {
                var SingletonService = scope.ServiceProvider.GetRequiredService<ISingletonService>();
                var ScopedService = scope.ServiceProvider.GetRequiredService<IScopedService>();
                var TraisientService = scope.ServiceProvider.GetRequiredService<ITraisientService>();

                Debug.WriteLine("The Singleton Time is {0}", SingletonService.Time);
                Debug.WriteLine("The Scope Time is {0}", ScopedService.Time);
                Debug.WriteLine("The Traisient Time is {0}", TraisientService.Time);
            }

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
