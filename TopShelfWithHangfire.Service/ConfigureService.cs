using System;
using System.Collections.Generic;
using System.Text;
using Topshelf;

namespace TopShelfWithHangfire.Service
{
    internal static class ConfigureService
    {
        internal static void Configure()
        {
            HostFactory.Run(configure =>
            {
                configure.Service<TopShelfWithHangfireService>(service =>
                {
                    service.ConstructUsing(s => new TopShelfWithHangfireService());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });
                configure.RunAsNetworkService();
                configure.SetServiceName("TopShelfWithHangfireService");
                configure.SetDisplayName("TopShelfWithHangfireService");
                configure.SetDescription("Top Shelf Service example with hangfire");
            });
        }
    }
}
