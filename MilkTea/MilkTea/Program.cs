namespace MilkTea
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
<<<<<<< HEAD
            Application.Run(new ChangePassword());
=======
            Application.Run(new AdminMenu());
>>>>>>> 5bf8e0a03a91988c36ad81478828f95fc13912b8
        }
    }
}