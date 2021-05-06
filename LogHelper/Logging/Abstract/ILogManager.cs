namespace LogHelper.Logging.Abstract
{
    public interface ILogManager
    {
        void Verbose(string message); // Verbose logging - Ayrıntı kaydı
        void Verbose<T>(string message, T t);
        void Fatal(string message); // Fatal logging - Önem kaydı
        void Fatal<T>(string message, T t);
        void Information(string message); // Information logging - Bilgilendirme kaydı
        void Information<T>(string message, T t);
        void Warning(string message); // Warning logging - Uyarı kaydı
        void Warning<T>(string message, T t);
        void Debug(string message); // Debug logging - Hata ayıklama kaydı
        void Debug<T>(string message, T t);
        void Error(string message); // Error logging - Hata kaydı
        void Error<T>(string message, T t);
    }
}