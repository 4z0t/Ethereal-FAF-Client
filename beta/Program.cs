using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;

namespace beta
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] Args) =>
            Host.CreateDefaultBuilder(Args)
            .ConfigureLogging(logging =>
            {

            })
            .UseContentRoot(App.CurrentDirectory)
            .ConfigureAppConfiguration((host, cfg) => cfg
            .SetBasePath(App.CurrentDirectory)
            // TODO: Some settings in json format, currently there is nothing, but maybe it will be useful
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true))
            .ConfigureServices(App.ConfigureServices);
    }
}