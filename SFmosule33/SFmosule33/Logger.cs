namespace SFmosule33
{
    public class Logger : ILogger
    {
        string eventLogFile = Path.Combine(Directory.GetCurrentDirectory(), $"events.txt");
        string errorLogFile = Path.Combine(Directory.GetCurrentDirectory(), $"error.txt");

        public Logger()
        {
            File.Create(eventLogFile).Close();
            File.Create(errorLogFile).Close();
        }

        public void WriteEvent(string eventMessage) { Console.WriteLine(eventMessage); }

        public void WriteError(string errorMessage) { Console.WriteLine(errorMessage); }

        public  void WriteEventLogToFile(string errorMessage)
        {
            if (!File.Exists(eventLogFile))           //файл лога должен создаваться при запуске программы
            {
                File.Create(eventLogFile).Close();
            }

            // Используем асинхронную запись в файл
             File.AppendAllTextAsync(eventLogFile, errorMessage+"\n");
        }

        public  void WriteErrorLogToFile(string errorMessage)
        {
            if (!File.Exists(errorLogFile))             //файл лога должен создаваться при запуске программы
            {
                File.Create(errorLogFile).Close();
            }

            // Используем асинхронную запись в файл
            File.AppendAllTextAsync(errorLogFile, errorMessage + "\n");
        }
    }
}
