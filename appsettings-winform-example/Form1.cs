using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appsettings_winform_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtAdminEmail.Text = AppSettings.Instance.adminEmail;
            txtAdminPassword.Text = AppSettings.Instance.adminPassword;
        }

        private void txtAdminEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
