﻿using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace writeboard.ext
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<WriteBoardExternal>()
                .Build();

            host.Run();
        }
    }
}
