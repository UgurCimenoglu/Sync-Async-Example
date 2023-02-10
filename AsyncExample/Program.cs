namespace AsyncExample
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //int available, max;
            //ThreadPool.GetAvailableThreads(out available, out max);

            //var pocessorCount = Environment.ProcessorCount;
            //ThreadPool.SetMaxThreads(Environment.ProcessorCount, Environment.ProcessorCount);

            //int available2, max2;
            //ThreadPool.GetAvailableThreads(out available2, out max2);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}