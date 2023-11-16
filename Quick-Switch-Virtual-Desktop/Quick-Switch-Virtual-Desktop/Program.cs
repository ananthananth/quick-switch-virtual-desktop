namespace Quick_Switch_Virtual_Desktop
{
    internal static class Program
    {
        private static string uid = "c37789bf-ea6f-4fd2-bb39-b7b5eed5426f";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            

            using (Mutex mutex = new Mutex(false, "Global\\" + uid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    return;
                }
                ApplicationConfiguration.Initialize();
                Application.Run(new Window());
            }

        }
    }
}