using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace appsettings_winform_example
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Remember to add Microft.Extensions
            // Load appsettings file
            var builder = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .AddEnvironmentVariables();
            var configuration = builder.Build();

            // read appsettings file and save it into AppSetting instance
            AppSettings.Instance.adminEmail = configuration.GetValue<String>("admin:email");
            AppSettings.Instance.adminPassword = configuration.GetValue<String>("admin:password");
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }
    }
}
