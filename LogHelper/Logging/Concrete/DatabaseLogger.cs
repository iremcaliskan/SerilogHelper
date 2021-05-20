using LogHelper.Logging.Abstract;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using System;
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
                .MSSqlServer(connectionString: configuration.GetConnectionString("ConnectionString"),tableName: "Logs", autoCreateSqlTable: true)
                .CreateLogger();
        }

        /*
         * The methods are filled according to DatabaseLogger - Metotlar DatabaseLogger'a göre doldurulur
         */
        
        // Information
        public void Information(string messageTemplate) => GetLogger().Information(messageTemplate);
        public void Information(string messageTemplate, params object[] propertyValues) => GetLogger().Information(messageTemplate, propertyValues);
        public void Information(Exception exception, string messageTemplate) => GetLogger().Information(exception, messageTemplate);
        public void Information(Exception exception, string messageTemplate, params object[] propertyValues) => GetLogger().Information(exception, messageTemplate, propertyValues);
        public void Information<T>(string messageTemplate, T propertyValue) => GetLogger().Information(messageTemplate, propertyValue);
        public void Information<T>(Exception exception, string messageTemplate, T propertyValue) => GetLogger().Information(exception, messageTemplate, propertyValue);
        public void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1) => GetLogger().Information(messageTemplate, propertyValue0, propertyValue1);
        public void Information<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1) => GetLogger().Error(exception, messageTemplate, propertyValue0, propertyValue1);

        // Error
        public void Error(string messageTemplate) => GetLogger().Error(messageTemplate);
        public void Error(string messageTemplate, params object[] propertyValues) => GetLogger().Error(messageTemplate, propertyValues);
        public void Error(Exception exception, string messageTemplate) => GetLogger().Error(exception, messageTemplate);
        public void Error(Exception exception, string messageTemplate, params object[] propertyValues) => GetLogger().Error(exception, messageTemplate, propertyValues);
        public void Error<T>(string messageTemplate, T propertyValue) => GetLogger().Error(messageTemplate, propertyValue);
        public void Error<T>(Exception exception, string messageTemplate, T propertyValue) => GetLogger().Error(exception, messageTemplate, propertyValue);
        public void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1) => GetLogger().Error(messageTemplate, propertyValue0, propertyValue1);
        public void Error<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1) => GetLogger().Error(exception, messageTemplate, propertyValue0, propertyValue1);

        // Fatal
        public void Fatal(string messageTemplate) => GetLogger().Fatal(messageTemplate);
        public void Fatal(string messageTemplate, params object[] propertyValues) => GetLogger().Fatal(messageTemplate, propertyValues);
        public void Fatal(Exception exception, string messageTemplate) => GetLogger().Fatal(exception, messageTemplate);
        public void Fatal(Exception exception, string messageTemplate, params object[] propertyValues) => GetLogger().Fatal(exception, messageTemplate, propertyValues);
        public void Fatal<T>(string messageTemplate, T propertyValue) => GetLogger().Fatal(messageTemplate, propertyValue);
        public void Fatal<T>(Exception exception, string messageTemplate, T propertyValue) => GetLogger().Fatal(exception, messageTemplate, propertyValue);
        public void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1) => GetLogger().Fatal(messageTemplate, propertyValue0, propertyValue1);
        public void Fatal<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1) => GetLogger().Fatal(exception, messageTemplate, propertyValue0, propertyValue1);

        // Warning
        public void Warning(string messageTemplate) => GetLogger().Warning(messageTemplate);
        public void Warning(string messageTemplate, params object[] propertyValues) => GetLogger().Warning(messageTemplate, propertyValues);
        public void Warning(Exception exception, string messageTemplate) => GetLogger().Warning(exception, messageTemplate);
        public void Warning(Exception exception, string messageTemplate, params object[] propertyValues) => GetLogger().Warning(exception, messageTemplate, propertyValues);
        public void Warning<T>(string messageTemplate, T propertyValue) => GetLogger().Warning(messageTemplate, propertyValue);
        public void Warning<T>(Exception exception, string messageTemplate, T propertyValue) => GetLogger().Warning(exception, messageTemplate, propertyValue);
        public void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1) => GetLogger().Warning(messageTemplate, propertyValue0, propertyValue1);
        public void Warning<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1) => GetLogger().Warning(exception, messageTemplate, propertyValue0, propertyValue1);

        // Debug
        public void Debug(string messageTemplate) => GetLogger().Debug(messageTemplate);
        public void Debug(string messageTemplate, params object[] propertyValues) => GetLogger().Debug(messageTemplate, propertyValues);
        public void Debug(Exception exception, string messageTemplate) => GetLogger().Debug(exception, messageTemplate);
        public void Debug(Exception exception, string messageTemplate, params object[] propertyValues) => GetLogger().Debug(exception, messageTemplate, propertyValues);
        public void Debug<T>(string messageTemplate, T propertyValue) => GetLogger().Debug(messageTemplate, propertyValue);
        public void Debug<T>(Exception exception, string messageTemplate, T propertyValue) => GetLogger().Debug(exception, messageTemplate, propertyValue);
        public void Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1) => GetLogger().Debug(messageTemplate, propertyValue0, propertyValue1);
        public void Debug<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1) => GetLogger().Debug(exception, messageTemplate, propertyValue0, propertyValue1);

        // Verbose
        public void Verbose(string messageTemplate) => GetLogger().Verbose(messageTemplate);
        public void Verbose(string messageTemplate, params object[] propertyValues) => GetLogger().Debug(messageTemplate, propertyValues);
        public void Verbose(Exception exception, string messageTemplate) => GetLogger().Debug(exception, messageTemplate);
        public void Verbose(Exception exception, string messageTemplate, params object[] propertyValues) => GetLogger().Debug(exception, messageTemplate, propertyValues);
        public void Verbose<T>(string messageTemplate, T propertyValue) => GetLogger().Verbose(messageTemplate, propertyValue);
        public void Verbose<T>(Exception exception, string messageTemplate, T propertyValue) => GetLogger().Debug(exception, messageTemplate, propertyValue);
        public void Verbose<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1) => GetLogger().Debug(messageTemplate, propertyValue0, propertyValue1);
        public void Verbose<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1) => GetLogger().Debug(exception, messageTemplate, propertyValue0, propertyValue1);
    }
}