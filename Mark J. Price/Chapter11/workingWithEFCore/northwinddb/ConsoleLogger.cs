using System;
using Microsoft.Extensions.Logging;

namespace northwinddb
{
    public class ConsoleLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName){
            return new ConsoleLogger();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
    public class ConsoleLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel){

            switch(logLevel){
                case LogLevel.Information:
                case LogLevel.None:
                    return false;
                case LogLevel.Debug:
                case LogLevel.Warning:
                case LogLevel.Error:
                case LogLevel.Critical:
                default:
                    return true;
            };           
        }

        public void Log<TState>(LogLevel logLevel, 
            EventId eventId, TState state, Exception exception,
            Func<TState, Exception, string> formatter){
            //log level the level and event identifier
            Console.WriteLine($"Level: {logLevel}, Event ID: {eventId.Id}");

            //only output the state or exception if it exists
            if(state != null){
                Console.WriteLine($", State: {state}");

            }
            if(exception != null){
                Console.WriteLine($", Exception: {exception.Message}");

            }
            
            Console.WriteLine();
        }
        
    }
}