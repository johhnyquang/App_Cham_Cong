using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Cham_Cong.GUI
{
    public partial class SettingDBForm : Form
    {
        public SettingDBForm()
        {
            InitializeComponent();
        }

        private void btnExitSettingDB_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
