using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiGeIES.Aplication.Services;
using SiGeIES.Domain.Contracts;
using SiGeIES.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace SiGeIES.Presentation.SiGeIESDesktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public IHost? HostApp { get; private set; }

        public App()
        {
            HostApp = Host.CreateDefaultBuilder()
                .ConfigureServices( (hostContext, services ) => 
                {
                    services.AddSingleton<MainWindow>();
                    services.AddScoped<IInasistenciaRepository, InasistenciaRepository>();
                    services.AddScoped<IInasistenciaService, InasistenciaService>();
                
                }).Build();

            
        }


        protected override async void OnStartup(StartupEventArgs e)
        {
            await HostApp!.StartAsync();

            var mainWindow = HostApp.Services.GetRequiredService<MainWindow>();
            mainWindow?.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await HostApp!.StopAsync();
            base.OnExit(e);
        }
    }
}
