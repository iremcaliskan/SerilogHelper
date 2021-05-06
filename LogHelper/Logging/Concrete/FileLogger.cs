using LogHelper.Logging.Abstract;
using Serilog;
using Serilog.Core;
using System.IO;

namespace LogHelper.Logging.Concrete
{
    public class FileLogger : LoggingConfiguration, ILogManager
    {
        private const string LogFolder = @"\LogFiles\"; // Folder path - Dosya yolu
        protected override Logger GetLogger()
        { // Create a Logger object that is provided by Serilog - GetLogger() metodu Serilog'un sağladığı Logger nesnesi üretir
            return new LoggerConfiguration()
                    .WriteTo.File(string.Format("{0}{1}", Directory.GetCurrentDirectory() + LogFolder, ".txt"), // File Name
                    rollingInterval: RollingInterval.Day, // Time to new file is one day - Günlük olarak loglama yapılacak
                    retainedFileCountLimit: null, // Max. number of log files will be null for no limit - Dosya sayısının limiitsiz olması için null
                    fileSizeLimitBytes: 5000000,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}")
                    .CreateLogger();
        }

        // The methods are filled according to FileLogger - Metotlar FileLogger'a göre doldurulur
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
