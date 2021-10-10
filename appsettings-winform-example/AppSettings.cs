using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appsettings_winform_example
{
    public class AppSettings
    {
        public String adminEmail;
        public String adminPassword;

        private AppSettings()
        {

        }

        public static readonly AppSettings Instance = new AppSettings();
    }
}
