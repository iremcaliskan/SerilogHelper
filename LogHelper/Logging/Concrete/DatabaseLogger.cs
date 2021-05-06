using LogHelper.Logging.Abstract;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using System.IO;

namespace LogHelper.Logging.Concrete
{
    public class DatabaseLogger : LoggingConfiguration, ILogManager
    {
        protected override Logger GetLogger()
        { // Create a Logger object that is provided by Serilog - GetLogger() metodu Serilog'un sağladığı Logger nesnesi üretir
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                 .Build();

            // The db configuration is done with the "ConnectionString" specified in appsettings.json and if there is no log table in db, it is created
            // - appsettings.json'da belirtilen "ConnectionString" ile db konfigurasyonu yapılır, veritabanında Log tablosu yok ise oto oluşturulur
            return new LoggerConfiguration().WriteTo
                .MSSqlServer(connectionString: configuration.GetConnectionString("ConnectionString"),tableName: "Log", autoCreateSqlTable: true)
                .CreateLogger();
        }

        // The methods are filled according to DatabaseLogger - Metotlar DatabaseLogger'a göre doldurulur
        public void Verbose(string message) => GetLogger().Verbose(message);
        public void Verbose<T>(string message, T t) => GetLogger().Verbose(message, t);
        public void Fatal(string message) => GetLogger().Fatal(message);
        public void Fatal<T>(string message, T t) => GetLogger().Fatal(message, t);
        public void Information(string message) => GetLogger().Information(message);
        public void Information<T>(string message, T t) => GetLogger().Information(message, t);
        public void Warning(string message) => GetLogger().Warning(message);
        public void Warning<T>(string message, T t) => GetLogger().Warning(message, t);
        public void Debug(string message) => GetLogger().Debug(message);
        public void Debug<T>(string message, T t) => GetLogger().Debug(message, t);
        public void Error(string message) => GetLogger().Error(message);
        public void Error<T>(string message, T t) => GetLogger().Error(message, t);
    }
}