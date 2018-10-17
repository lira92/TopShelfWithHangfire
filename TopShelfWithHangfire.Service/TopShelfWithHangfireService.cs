using Hangfire;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TopShelfWithHangfire.Service
{
    public class TopShelfWithHangfireService
    {
        private BackgroundJobServer _server;

        public TopShelfWithHangfireService()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            GlobalConfiguration.Configuration.UseSqlServerStorage(config.GetConnectionString("HangfireConnection"));
        }

        public void Start()
        {
            _server = new BackgroundJobServer();
            BackgroundTasks.Configure();
        }

        public void Stop()
        {
            _server.Dispose();
        }
    }
}
