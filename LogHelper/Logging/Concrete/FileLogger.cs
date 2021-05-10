using LogHelper.Logging.Abstract;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System;
using System.IO;

namespace LogHelper.Logging.Concrete
{
    public class FileLogger : LoggingConfiguration, ILogManager
    {
        private readonly string LogFolderPath = @"C:\Users\ASUS\OneDrive\Belgeler\GitHub\SerilogHelper\LogFiles\"; // Folder path - Dosya yolu
        public FileLogger()
        {
            ControlDirectories(LogFolderPath);
        }

        private void ControlDirectories(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine(path);
            }

            if (!Directory.Exists(path + @"\Error\"))
            {
                Directory.CreateDirectory(path + @"\Error\");
                Console.WriteLine(path + @"\Error\");
            }

            if (!Directory.Exists(path + @"\Information\"))
            {
                Directory.CreateDirectory(path + @"\Information\");
                Console.WriteLine(path + @"\Information\");
            }

            if (!Directory.Exists(path + @"\Other\"))
            {
                Directory.CreateDirectory(path + @"\Other\");
                Console.WriteLine(path + @"\Other\");
            }
        }

        protected override Logger GetLogger()
        { // Create a Logger object that is provided by Serilog - GetLogger() metodu Serilog'un sağladığı Logger nesnesi üretir
            return new LoggerConfiguration()
                .WriteTo.Logger(lc => lc.Filter.ByIncludingOnly(error => error.Level == LogEventLevel.Error))
                .WriteTo.File(string.Format(@"{0}\Error\error-.log", LogFolderPath), LogEventLevel.Error, rollingInterval: RollingInterval.Day, retainedFileCountLimit: null, fileSizeLimitBytes: 5000000, outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz}  {Level}] {Message:lj}{NewLine}{Exception}")

                .WriteTo.Logger(lc => lc.Filter.ByIncludingOnly(info => info.Level == LogEventLevel.Information))
                .WriteTo.File(string.Format(@"{0}\Information\information-.log", LogFolderPath), LogEventLevel.Information, rollingInterval: RollingInterval.Day, retainedFileCountLimit: null, fileSizeLimitBytes: 5000000, outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz}  {Level}] {Message:lj}{NewLine}{Exception}")

                .WriteTo.Logger(lc => lc.Filter.ByExcluding(other => other.Level == LogEventLevel.Error && other.Level == LogEventLevel.Information))
                .WriteTo.File(string.Format(@"{0}\Other\other-.log", LogFolderPath), rollingInterval: RollingInterval.Day, retainedFileCountLimit: null, fileSizeLimitBytes: 5000000, outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz}  {Level}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

            //return new LoggerConfiguration()
            //        .WriteTo.File(string.Format("{0}{1}", Directory.GetCurrentDirectory() + LogFolder, ".txt"), // File Name
            //        rollingInterval: RollingInterval.Day, // Time to new file is one day - Günlük olarak loglama yapılacak
            //        retainedFileCountLimit: null, // Max. number of log files will be null for no limit - Dosya sayısının limiitsiz olması için null
            //        fileSizeLimitBytes: 5000000,
            //        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}")
            //        .CreateLogger();
        }

        /*
         * The methods are filled according to FileLogger - Metotlar FileLogger'a göre doldurulur
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
