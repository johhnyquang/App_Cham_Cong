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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void picAvtMember_Click(object sender, EventArgs e)
        {

        }

        private Image settingSizePicture(Image picture,Size size)
        {
            return (Image)(new Bitmap(picture, size));
        }

        private void MainManagementForm_Load(object sender, EventArgs e)
        {
            // Lấy ra cái ảnh trước đã
            Image path = Image.FromFile("icons8-user-25.png");

            // Set Kích Thước cho ảnh
            Image newPic = settingSizePicture(path, new Size(50, 50));  
            
            // Set ảnh vào trong Picture Box
            picAvtMember.Image = newPic;

            // Set sizeMode cho bức ảnh
            picAvtMember.SizeMode = PictureBoxSizeMode.StretchImage;
            
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
