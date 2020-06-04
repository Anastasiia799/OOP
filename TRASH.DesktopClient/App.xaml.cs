using Microsoft.Extensions.DependencyInjection;
using TRASH.ApplicationServices.GetYardAreaListUseCase;
using TRASH.ApplicationServices.Ports.Cache;
using TRASH.ApplicationServices.Repositories;
using TRASH.DesktopClient.InfrastructureServices.ViewModels;
using TRASH.DomainObjects;
using TRASH.DomainObjects.Ports;
using TRASH.InfrastructureServices.Cache;
using TRASH.InfrastructureServices.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;








namespace TRASH.DesktopClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDomainObjectsCache<trash>, DomainObjectsMemoryCache<trash>>();
            services.AddSingleton<NetworkTRASHRepository>(
                x => new NetworkTRASHRepository("localhost", 80, useTls: false, x.GetRequiredService<IDomainObjectsCache<trash>>())
            );
            services.AddSingleton<CachedReadOnlyTRASHRepository>(
                x => new CachedReadOnlyTRASHRepository(
                    x.GetRequiredService<NetworkTRASHRepository>(), 
                    x.GetRequiredService<IDomainObjectsCache<trash>>()
                )
            );
            services.AddSingleton<IReadOnlyTRASHRepository>(x => x.GetRequiredService<CachedReadOnlyTRASHRepository>());
            services.AddSingleton<IGetTRASHListUseCase, GetTRASHListUseCase>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs args)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
