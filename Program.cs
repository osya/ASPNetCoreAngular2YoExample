using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ASPNetCoreAngular2YoExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        private static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
