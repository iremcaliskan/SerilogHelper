using System;

namespace LogHelper.Logging.Abstract
{
    public interface ILogManager
    {
        /* In general terms:
         * Information Level - Informational messages that might make sense to end users and system administrators, and highlight the progress of the application
         * ( Son kullanıcılar ve sistem yöneticileri için anlamlı olabilecek ve uygulamanın ilerlemesini vurgulayabilecek bilgilendirici mesajlar )
         * 
         * Error Level - Error events of considerable importance that will prevent normal program execution, but might still allow the application to continue running
         * ( Normal programın yürütülmesini engelleyecek, ancak yine de uygulamanın çalışmaya devam etmesine izin verebilecek önemli hata olayları )
         * 
         * Fatal Level - Very severe error events that might cause the application to terminate
         * ( Uygulamanın sonlanmasına neden olabilecek çok ciddi hata olayları )
         * 
         * Warning Level - Potentially harmful situations of interest to end users or system managers that indicate potential problems
         * ( Olası sorunları gösteren, son kullanıcılar veya sistem yöneticileri için potansiyel olarak zararlı durumlar )
         * 
         * Debug Level - Relatively detailed tracing used by application developers
         * ( Uygulama geliştiricileri tarafından kullanılan nispeten ayrıntılı izleme )
         * 
         * Verbose Level - Computer logging mode that records more information than the usual logging mode. (Verbose means "using more words than necessary".) Verbose logging options are usually enabled specifically for troubleshooting because they create large log files and can slow down performance.
         * ( Normal günlük modundan daha fazla bilgi kaydeden bilgisayar günlük modu )
         * ( Verbose, "gerekenden daha fazla kelime kullanmak" anlamına gelir )
         * ( Ayrıntılı günlük kaydı seçenekleri genellikle büyük günlük dosyaları oluşturduğundan ve performansı yavaşlatabildiğinden özellikle sorun giderme için etkinleştirilir )
         */

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        void Information(string messageTemplate);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level and
        //     associated exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        void Information(Exception exception, string messageTemplate);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level and
        //     associated exception.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        void Information(string messageTemplate, params object[] propertyValues);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level and
        //     associated exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        void Information(Exception exception, string messageTemplate, params object[] propertyValues);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        void Information<T>(string messageTemplate, T propertyValue);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level and
        //     associated exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        void Information<T>(Exception exception, string messageTemplate, T propertyValue);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level and
        //     associated exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        void Information<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        void Error(string messageTemplate);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        void Error(Exception exception, string messageTemplate);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level and associated
        //     exception.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        void Error(string messageTemplate, params object[] propertyValues);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        void Error(Exception exception, string messageTemplate, params object[] propertyValues);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        void Error<T>(string messageTemplate, T propertyValue);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        void Error<T>(Exception exception, string messageTemplate, T propertyValue);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        void Error<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        void Fatal(string messageTemplate);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        void Fatal(Exception exception, string messageTemplate);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level and associated
        //     exception.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        void Fatal(string messageTemplate, params object[] propertyValues);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        void Fatal(Exception exception, string messageTemplate, params object[] propertyValues);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        void Fatal<T>(string messageTemplate, T propertyValue);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        void Fatal<T>(Exception exception, string messageTemplate, T propertyValue);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        void Fatal<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        void Warning(string messageTemplate);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        void Warning(Exception exception, string messageTemplate);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level and associated
        //     exception.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        void Warning(string messageTemplate, params object[] propertyValues);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        void Warning(Exception exception, string messageTemplate, params object[] propertyValues);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        void Warning<T>(string messageTemplate, T propertyValue);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        void Warning<T>(Exception exception, string messageTemplate, T propertyValue);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        void Warning<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        void Debug(string messageTemplate);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level and associated
        //     exception.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        void Debug(string messageTemplate, params object[] propertyValues);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        void Debug(Exception exception, string messageTemplate);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        void Debug(Exception exception, string messageTemplate, params object[] propertyValues);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        void Debug<T>(string messageTemplate, T propertyValue);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        void Debug<T>(Exception exception, string messageTemplate, T propertyValue);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        void Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        void Debug<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        void Verbose(string messageTemplate);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level and associated
        //     exception.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        void Verbose(string messageTemplate, params object[] propertyValues);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        void Verbose(Exception exception, string messageTemplate);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        void Verbose(Exception exception, string messageTemplate, params object[] propertyValues);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        void Verbose<T>(string messageTemplate, T propertyValue);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        void Verbose<T>(Exception exception, string messageTemplate, T propertyValue);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level.
        //
        // Parameters:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        void Verbose<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        // Summary:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level and associated
        //     exception.
        //
        // Parameters:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        void Verbose<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    }
}