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
    public partial class frmMainAdmin : Form
    {
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        private void frmMainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pnYellow_MouseClick(object sender, MouseEventArgs e)
        {
            pnMainSub.BackColor = Color.LightGoldenrodYellow;
        }

        private void pnRed_MouseClick(object sender, MouseEventArgs e)
        {
            pnMainSub.BackColor= Color.OrangeRed;
        }

        private void pnBlue_MouseClick(object sender, MouseEventArgs e)
        {
            pnMainSub.BackColor = Color.Blue;
        }

        private void pnOrange_MouseClick(object sender, MouseEventArgs e)
        {
            pnMainSub.BackColor = Color.Orange;
        }

        private void pnGreen_MouseClick(object sender, MouseEventArgs e)
        {
            pnMainSub.BackColor = Color.ForestGreen;
        }
    }
}
