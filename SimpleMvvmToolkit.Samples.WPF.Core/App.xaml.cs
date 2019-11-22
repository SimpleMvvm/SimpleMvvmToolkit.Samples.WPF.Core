using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using SimpleMvvmToolkit.Samples.WPF.Core.Services;
using SimpleMvvmToolkit.Samples.WPF.Core.ViewModels;
using SimpleMvvmToolkit.Samples.WPF.Core.Views;

namespace SimpleMvvmToolkit.Samples.WPF.Core
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ServiceProvider ServiceProvider { get; }

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = ServiceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICustomerService, MockCustomerService>();
            services.AddSingleton<CustomerViewModel>();
            services.AddSingleton<MainPageViewModel>();
            services.AddSingleton<CustomerView>();
            services.AddSingleton<MainWindow>();
        }
    }
}
