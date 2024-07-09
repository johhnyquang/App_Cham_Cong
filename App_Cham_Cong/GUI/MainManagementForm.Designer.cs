namespace App_Cham_Cong.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnGreen = new System.Windows.Forms.Panel();
            this.pnOrange = new System.Windows.Forms.Panel();
            this.pnBlue = new System.Windows.Forms.Panel();
            this.pnRed = new System.Windows.Forms.Panel();
            this.pnYellow = new System.Windows.Forms.Panel();
            this.lbNameMember = new System.Windows.Forms.Label();
            this.pnMainSub = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnInfoBOx = new System.Windows.Forms.Panel();
            this.picInfoBox = new System.Windows.Forms.PictureBox();
            this.btnDoiMKForm = new System.Windows.Forms.Button();
            this.btnChinhSuaGioCongForm = new System.Windows.Forms.Button();
            this.btnDuLieuChamCongForm = new System.Windows.Forms.Button();
            this.btnBangLuongForm = new System.Windows.Forms.Button();
            this.btnSapLichLamViecForm = new System.Windows.Forms.Button();
            this.picAvtMember = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameEmp = new System.Windows.Forms.TextBox();
            this.txtBirthdayEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPositionEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnMainSub.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnInfoBOx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvtMember)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnMainSub);
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Location = new System.Drawing.Point(0, 3);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1015, 543);
            this.pnMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnGreen);
            this.panel1.Controls.Add(this.pnOrange);
            this.panel1.Controls.Add(this.pnBlue);
            this.panel1.Controls.Add(this.pnRed);
            this.panel1.Controls.Add(this.pnYellow);
            this.panel1.Controls.Add(this.lbNameMember);
            this.panel1.Controls.Add(this.picAvtMember);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 90);
            this.panel1.TabIndex = 0;
            // 
            // pnGreen
            // 
            this.pnGreen.BackColor = System.Drawing.Color.Lime;
            this.pnGreen.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnGreen.Location = new System.Drawing.Point(928, 23);
            this.pnGreen.Name = "pnGreen";
            this.pnGreen.Size = new System.Drawing.Size(67, 53);
            this.pnGreen.TabIndex = 3;
            this.pnGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnGreen_MouseClick);
            // 
            // pnOrange
            // 
            this.pnOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnOrange.Location = new System.Drawing.Point(846, 23);
            this.pnOrange.Name = "pnOrange";
            this.pnOrange.Size = new System.Drawing.Size(67, 53);
            this.pnOrange.TabIndex = 3;
            this.pnOrange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnOrange_MouseClick);
            // 
            // pnBlue
            // 
            this.pnBlue.BackColor = System.Drawing.Color.Blue;
            this.pnBlue.Location = new System.Drawing.Point(756, 23);
            this.pnBlue.Name = "pnBlue";
            this.pnBlue.Size = new System.Drawing.Size(67, 53);
            this.pnBlue.TabIndex = 3;
            this.pnBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnBlue_MouseClick);
            // 
            // pnRed
            // 
            this.pnRed.BackColor = System.Drawing.Color.Red;
            this.pnRed.Location = new System.Drawing.Point(661, 23);
            this.pnRed.Name = "pnRed";
            this.pnRed.Size = new System.Drawing.Size(67, 53);
            this.pnRed.TabIndex = 3;
            this.pnRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnRed_MouseClick);
            // 
            // pnYellow
            // 
            this.pnYellow.BackColor = System.Drawing.Color.Yellow;
            this.pnYellow.Location = new System.Drawing.Point(564, 23);
            this.pnYellow.Name = "pnYellow";
            this.pnYellow.Size = new System.Drawing.Size(67, 53);
            this.pnYellow.TabIndex = 2;
            this.pnYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnYellow_MouseClick);
            // 
            // lbNameMember
            // 
            this.lbNameMember.AutoSize = true;
            this.lbNameMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameMember.Location = new System.Drawing.Point(109, 31);
            this.lbNameMember.Name = "lbNameMember";
            this.lbNameMember.Size = new System.Drawing.Size(337, 32);
            this.lbNameMember.TabIndex = 1;
            this.lbNameMember.Text = "Tên Nhân Viên (Thay đổi)";
            // 
            // pnMainSub
            // 
            this.pnMainSub.Controls.Add(this.pnInfoBOx);
            this.pnMainSub.Controls.Add(this.panel2);
            this.pnMainSub.Location = new System.Drawing.Point(-6, 98);
            this.pnMainSub.Name = "pnMainSub";
            this.pnMainSub.Size = new System.Drawing.Size(1020, 430);
            this.pnMainSub.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Violet;
            this.panel2.Controls.Add(this.btnDoiMKForm);
            this.panel2.Controls.Add(this.btnChinhSuaGioCongForm);
            this.panel2.Controls.Add(this.btnDuLieuChamCongForm);
            this.panel2.Controls.Add(this.btnBangLuongForm);
            this.panel2.Controls.Add(this.btnSapLichLamViecForm);
            this.panel2.Location = new System.Drawing.Point(18, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 390);
            this.panel2.TabIndex = 0;
            // 
            // pnInfoBOx
            // 
            this.pnInfoBOx.Controls.Add(this.txtPositionEmp);
            this.pnInfoBOx.Controls.Add(this.label4);
            this.pnInfoBOx.Controls.Add(this.txtBirthdayEmp);
            this.pnInfoBOx.Controls.Add(this.label3);
            this.pnInfoBOx.Controls.Add(this.txtNameEmp);
            this.pnInfoBOx.Controls.Add(this.label2);
            this.pnInfoBOx.Controls.Add(this.label1);
            this.pnInfoBOx.Controls.Add(this.picInfoBox);
            this.pnInfoBOx.Location = new System.Drawing.Point(268, 17);
            this.pnInfoBOx.Name = "pnInfoBOx";
            this.pnInfoBOx.Size = new System.Drawing.Size(735, 388);
            this.pnInfoBOx.TabIndex = 1;
            // 
            // picInfoBox
            // 
            this.picInfoBox.Image = global::App_Cham_Cong.Properties.Resources.QUANG_TUẤN;
            this.picInfoBox.Location = new System.Drawing.Point(283, 8);
            this.picInfoBox.Name = "picInfoBox";
            this.picInfoBox.Size = new System.Drawing.Size(451, 379);
            this.picInfoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picInfoBox.TabIndex = 0;
            this.picInfoBox.TabStop = false;
            // 
            // btnDoiMKForm
            // 
            this.btnDoiMKForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMKForm.Image = global::App_Cham_Cong.Properties.Resources.icons8_change_25;
            this.btnDoiMKForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMKForm.Location = new System.Drawing.Point(10, 312);
            this.btnDoiMKForm.Name = "btnDoiMKForm";
            this.btnDoiMKForm.Size = new System.Drawing.Size(200, 51);
            this.btnDoiMKForm.TabIndex = 4;
            this.btnDoiMKForm.Text = "Đổi mật khẩu";
            this.btnDoiMKForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMKForm.UseVisualStyleBackColor = true;
            // 
            // btnChinhSuaGioCongForm
            // 
            this.btnChinhSuaGioCongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSuaGioCongForm.Image = global::App_Cham_Cong.Properties.Resources.icons8_edit_25;
            this.btnChinhSuaGioCongForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSuaGioCongForm.Location = new System.Drawing.Point(11, 244);
            this.btnChinhSuaGioCongForm.Name = "btnChinhSuaGioCongForm";
            this.btnChinhSuaGioCongForm.Size = new System.Drawing.Size(200, 51);
            this.btnChinhSuaGioCongForm.TabIndex = 3;
            this.btnChinhSuaGioCongForm.Text = "Chỉnh sửa giờ công";
            this.btnChinhSuaGioCongForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSuaGioCongForm.UseVisualStyleBackColor = true;
            // 
            // btnDuLieuChamCongForm
            // 
            this.btnDuLieuChamCongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuLieuChamCongForm.Image = global::App_Cham_Cong.Properties.Resources.icons8_natural_user_interface_2_25;
            this.btnDuLieuChamCongForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuLieuChamCongForm.Location = new System.Drawing.Point(11, 170);
            this.btnDuLieuChamCongForm.Name = "btnDuLieuChamCongForm";
            this.btnDuLieuChamCongForm.Size = new System.Drawing.Size(200, 51);
            this.btnDuLieuChamCongForm.TabIndex = 2;
            this.btnDuLieuChamCongForm.Text = "Chấm công";
            this.btnDuLieuChamCongForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuLieuChamCongForm.UseVisualStyleBackColor = true;
            // 
            // btnBangLuongForm
            // 
            this.btnBangLuongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangLuongForm.Image = global::App_Cham_Cong.Properties.Resources.icons8_money_25;
            this.btnBangLuongForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBangLuongForm.Location = new System.Drawing.Point(10, 95);
            this.btnBangLuongForm.Name = "btnBangLuongForm";
            this.btnBangLuongForm.Size = new System.Drawing.Size(200, 51);
            this.btnBangLuongForm.TabIndex = 1;
            this.btnBangLuongForm.Text = "Bảng tính lương";
            this.btnBangLuongForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBangLuongForm.UseVisualStyleBackColor = true;
            // 
            // btnSapLichLamViecForm
            // 
            this.btnSapLichLamViecForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapLichLamViecForm.Image = global::App_Cham_Cong.Properties.Resources.icons8_calendar_plus_25;
            this.btnSapLichLamViecForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSapLichLamViecForm.Location = new System.Drawing.Point(10, 16);
            this.btnSapLichLamViecForm.Name = "btnSapLichLamViecForm";
            this.btnSapLichLamViecForm.Size = new System.Drawing.Size(200, 51);
            this.btnSapLichLamViecForm.TabIndex = 0;
            this.btnSapLichLamViecForm.Text = "Sắp lịch làm việc";
            this.btnSapLichLamViecForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapLichLamViecForm.UseVisualStyleBackColor = true;
            // 
            // picAvtMember
            // 
            this.picAvtMember.Location = new System.Drawing.Point(26, 17);
            this.picAvtMember.Name = "picAvtMember";
            this.picAvtMember.Size = new System.Drawing.Size(66, 59);
            this.picAvtMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvtMember.TabIndex = 0;
            this.picAvtMember.TabStop = false;
            this.picAvtMember.Click += new System.EventHandler(this.picAvtMember_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hồ sơ nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtNameEmp
            // 
            this.txtNameEmp.Enabled = false;
            this.txtNameEmp.Location = new System.Drawing.Point(28, 137);
            this.txtNameEmp.Name = "txtNameEmp";
            this.txtNameEmp.Size = new System.Drawing.Size(212, 22);
            this.txtNameEmp.TabIndex = 6;
            this.txtNameEmp.Text = "Trần Quang Tuấn";
            // 
            // txtBirthdayEmp
            // 
            this.txtBirthdayEmp.Enabled = false;
            this.txtBirthdayEmp.Location = new System.Drawing.Point(28, 218);
            this.txtBirthdayEmp.Name = "txtBirthdayEmp";
            this.txtBirthdayEmp.Size = new System.Drawing.Size(212, 22);
            this.txtBirthdayEmp.TabIndex = 8;
            this.txtBirthdayEmp.Text = "14/10/2003";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày sinh";
            // 
            // txtPositionEmp
            // 
            this.txtPositionEmp.Enabled = false;
            this.txtPositionEmp.Location = new System.Drawing.Point(29, 307);
            this.txtPositionEmp.Name = "txtPositionEmp";
            this.txtPositionEmp.Size = new System.Drawing.Size(212, 22);
            this.txtPositionEmp.TabIndex = 10;
            this.txtPositionEmp.Text = "Quản Lý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chức vụ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 558);
            this.Controls.Add(this.pnMain);
            this.Name = "frmMain";
            this.Text = "MainManagementForm";
            this.Load += new System.EventHandler(this.MainManagementForm_Load);
            this.pnMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnMainSub.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnInfoBOx.ResumeLayout(false);
            this.pnInfoBOx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvtMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAvtMember;
        private System.Windows.Forms.Panel pnGreen;
        private System.Windows.Forms.Panel pnOrange;
        private System.Windows.Forms.Panel pnBlue;
        private System.Windows.Forms.Panel pnRed;
        private System.Windows.Forms.Panel pnYellow;
        private System.Windows.Forms.Label lbNameMember;
        private System.Windows.Forms.Panel pnMainSub;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSapLichLamViecForm;
        private System.Windows.Forms.Button btnBangLuongForm;
        private System.Windows.Forms.Button btnDuLieuChamCongForm;
        private System.Windows.Forms.Button btnChinhSuaGioCongForm;
        private System.Windows.Forms.Button btnDoiMKForm;
        private System.Windows.Forms.Panel pnInfoBOx;
        private System.Windows.Forms.PictureBox picInfoBox;
        private System.Windows.Forms.TextBox txtBirthdayEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPositionEmp;
        private System.Windows.Forms.Label label4;
    }
}