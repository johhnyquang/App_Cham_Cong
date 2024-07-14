using App_Cham_Cong.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Cham_Cong
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void picSettingDB_Click(object sender, EventArgs e)
        {
            SettingDBForm settingDBForm = new SettingDBForm();
            this.Hide();
            settingDBForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //frmMainManagement main = new frmMainManagement();
            //this.Hide();
            //main.ShowDialog();

            frmMainAdmin main  = new frmMainAdmin();
            this.Hide();
            main.ShowDialog();
        }
    }
}
