using System;
using Microsoft.AspNetCore.Hosting;

namespace WebCore.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Program>()
                .Build();
        }
    }
}
