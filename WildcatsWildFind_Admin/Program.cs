namespace WildcatsWildFind_Admin
{
    internal static class Program
    {
        private static string username;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new AdminLogin());
            Application.Run(new Dashboard(username));
        }
    }
}