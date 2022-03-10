using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbCosmosApi.Middlewares
{
    public static class LogginMiddleware
    {
        public static void AddLoggerMiddleware(this IServiceCollection services)
        {
            var logger = UseLoggerMiddleware();

            logger.Write(LogEventLevel.Information, "Application initialized");
        }

        private static Logger UseLoggerMiddleware()
        {
            var logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo(@"log.txt",
                    retainedFileCountLimit: 8, fileSizeLimitBytes: 409600)
                .CreateLogger();

            return logger;
        }
    }
}
