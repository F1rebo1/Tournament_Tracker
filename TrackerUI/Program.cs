namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Initialize the database connections
            //TrackerLibrary.GlobalConfig.InitializeConections(TrackerLibrary.DatabaseType.Sql);
            TrackerLibrary.GlobalConfig.InitializeConections(TrackerLibrary.DatabaseType.Sql);

            Application.Run(new CreateTeamForm());
            //Application.Run(new TournamentDashboardForm());
        }
    }
}