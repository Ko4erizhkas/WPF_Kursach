using WPF_Kursach.ActionForms;
using WPF_Kursach.AnotherDirectory.MainForms;

namespace WPF_Kursach
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
            Application.Run(new MainFormV2());
            //Application.Run(new UploadInfoFromJsonForm());
        }
    }
}