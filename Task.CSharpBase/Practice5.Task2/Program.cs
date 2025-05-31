using Logger;
using Logger.LoggersImpl;
namespace Practice5.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger();
            logger.Info("Тест логгера");
            logger.Debug("Дебаг");
        }
    }
}