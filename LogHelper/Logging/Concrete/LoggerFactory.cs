using System;

namespace LogHelper.Logging.Concrete
{
    public class LoggerFactory
    { // When this class is called, both loggers are easily accessible - Bu sınıf çağırılınca iki Logger'a da rahatlıkla ulaşılır
        // Factory Method Pattern
        static readonly object _lock = new object();
        private static DatabaseLogger _databaseLogger;
        private static FileLogger _fileLogger;
        private LoggerFactory()
        {

        }
        // While accessing the loggers, creating an object will be arranged by putting in with Singleton Pattern
        // - Loggerlar'a ulaşırken, Singleton Pattern ile araya girilip nesne üretme işlemi düzenlenecek

        public static DatabaseLogger DatabaseLogManager()
        {
            if (_databaseLogger == null) // Double checked locking, singleton
            {
                lock (_lock) // thread safe, singleton
                {
                    if (_databaseLogger == null)
                        _databaseLogger = new DatabaseLogger();
                }
            }
            return _databaseLogger;
        }

        public static FileLogger FileLogManager()
        {
            if (_fileLogger == null)
            {
                lock (_lock)
                {
                    if (_fileLogger == null)
                        _fileLogger = new FileLogger();
                }
            }
            return _fileLogger;
        }
    }
}