namespace FINAL_PROJECT_DRAFTZ_5_
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
            LandingForm landingForm = new LandingForm();
            Application.Run(landingForm);

            Database database = new Database();
            database.getStudentData();
        }
    }
}