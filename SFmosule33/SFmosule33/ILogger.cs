namespace SFmosule33
{
    public interface ILogger
    {
        public void WriteEvent(string eventMessage);

        public void WriteError(string errorMessage);

        public void WriteEventLogToFile(string errorMessage);
        public void WriteErrorLogToFile(string errorMessage);

    }
}
