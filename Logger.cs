using System;

namespace M02HW01
{
    public class Logger
    {
        private static readonly Logger instance = new Logger();
        private string logs = "";

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return instance;
            }
        }

        public void LogInfo(string message)
        {
           var log = $"{DateTime.Now}: Info: {message}\n";
           Console.WriteLine(log);
           File.WriteAllText("log.txt", log);
        }

        public void LogWarning(string message)
        {
            var log = $"{DateTime.Now}: Warning: {message}\n";
            Console.WriteLine(log);
            File.WriteAllText("log.txt", log);
        }

        public void LogError(string message)
        {
            var log = $"{DateTime.Now}: Error: {message}\n";
            Console.WriteLine(log);
            File.WriteAllText("log.txt", log);
        }

        public string GetAllLogs()
        {
            return logs;
        }
    }
}