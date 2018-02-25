using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;
// crtl r g 
namespace T_001_Basic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }
        // 30.22
        public static IWebHost BuildWebHost(string[] args) {
            return new WebHostBuilder()
                  .UseKestrel()
                  .UseContentRoot(Directory.GetCurrentDirectory())
                  .UseStartup<Startup>()
                  .Build();
        }
    }
}
