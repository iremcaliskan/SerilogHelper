using Serilog.Core;

namespace LogHelper.Logging.Concrete
{
    public abstract class LoggingConfiguration
    { // Base class for all logging types - Loglama sınıflarına temel, inherit alınacak sınıf
        protected abstract Logger GetLogger();

        public Logger InstanceLogger()
        {
            return default(Logger); // Pipeline - Veri hattı, ardışık düzen
        }
    }
}