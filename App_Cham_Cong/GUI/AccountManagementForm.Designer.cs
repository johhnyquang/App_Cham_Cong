namespace App_Cham_Cong.GUI
{
    partial class AccountManagementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGroupID = new System.Windows.Forms.ComboBox();
            this.txtAccountFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordAccountUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAccountUser = new System.Windows.Forms.DataGridView();
            this.AccountUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddAccountUser = new System.Windows.Forms.Button();
            this.btnDeleteAccountUser = new System.Windows.Forms.Button();
            this.btnEditAccountUser = new System.Windows.Forms.Button();
            this.picAccountFullName = new System.Windows.Forms.PictureBox();
            this.picPassAccountUser = new System.Windows.Forms.PictureBox();
            this.picAccountUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccountFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassAccountUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccountUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditAccountUser);
            this.panel1.Controls.Add(this.btnDeleteAccountUser);
            this.panel1.Controls.Add(this.btnAddAccountUser);
            this.panel1.Controls.Add(this.dgvAccountUser);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboGroupID);
            this.panel1.Controls.Add(this.picAccountFullName);
            this.panel1.Controls.Add(this.txtAccountFullName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.picPassAccountUser);
            this.panel1.Controls.Add(this.txtPasswordAccountUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picAccountUser);
            this.panel1.Controls.Add(this.txtAccountUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 756);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(317, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 67);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(47, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh sách các tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chức Vụ";
            // 
            // cboGroupID
            // 
            this.cboGroupID.FormattingEnabled = true;
            this.cboGroupID.Location = new System.Drawing.Point(236, 267);
            this.cboGroupID.Name = "cboGroupID";
            this.cboGroupID.Size = new System.Drawing.Size(157, 24);
            this.cboGroupID.TabIndex = 10;
            // 
            // txtAccountFullName
            // 
            this.txtAccountFullName.Location = new System.Drawing.Point(236, 214);
            this.txtAccountFullName.Name = "txtAccountFullName";
            this.txtAccountFullName.Size = new System.Drawing.Size(343, 22);
            this.txtAccountFullName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Họ Và Tên";
            // 
            // txtPasswordAccountUser
            // 
            this.txtPasswordAccountUser.Location = new System.Drawing.Point(236, 157);
            this.txtPasswordAccountUser.Name = "txtPasswordAccountUser";
            this.txtPasswordAccountUser.Size = new System.Drawing.Size(343, 22);
            this.txtPasswordAccountUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtAccountUser
            // 
            this.txtAccountUser.Location = new System.Drawing.Point(236, 101);
            this.txtAccountUser.Name = "txtAccountUser";
            this.txtAccountUser.Size = new System.Drawing.Size(343, 22);
            this.txtAccountUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(317, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 67);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(62, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo Tài Khoản";
            // 
            // dgvAccountUser
            // 
            this.dgvAccountUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountUser,
            this.AccountPass,
            this.AccountFullName,
            this.UpdateBy,
            this.UpdateTime});
            this.dgvAccountUser.Location = new System.Drawing.Point(118, 432);
            this.dgvAccountUser.Name = "dgvAccountUser";
            this.dgvAccountUser.RowHeadersWidth = 51;
            this.dgvAccountUser.RowTemplate.Height = 24;
            this.dgvAccountUser.Size = new System.Drawing.Size(684, 128);
            this.dgvAccountUser.TabIndex = 12;
            // 
            // AccountUser
            // 
            this.AccountUser.HeaderText = "Tên Đăng Nhập";
            this.AccountUser.MinimumWidth = 6;
            this.AccountUser.Name = "AccountUser";
            this.AccountUser.Width = 125;
            // 
            // AccountPass
            // 
            this.AccountPass.HeaderText = "Mật Khẩu";
            this.AccountPass.MinimumWidth = 6;
            this.AccountPass.Name = "AccountPass";
            this.AccountPass.Width = 125;
            // 
            // AccountFullName
            // 
            this.AccountFullName.HeaderText = "Họ Và Tên";
            this.AccountFullName.MinimumWidth = 6;
            this.AccountFullName.Name = "AccountFullName";
            this.AccountFullName.Width = 125;
            // 
            // UpdateBy
            // 
            this.UpdateBy.HeaderText = "Cập Nhật Bởi";
            this.UpdateBy.MinimumWidth = 6;
            this.UpdateBy.Name = "UpdateBy";
            this.UpdateBy.Width = 125;
            // 
            // UpdateTime
            // 
            this.UpdateTime.HeaderText = "Thời gian Cập Nhật";
            this.UpdateTime.MinimumWidth = 6;
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.Width = 125;
            // 
            // btnAddAccountUser
            // 
            this.btnAddAccountUser.Location = new System.Drawing.Point(36, 625);
            this.btnAddAccountUser.Name = "btnAddAccountUser";
            this.btnAddAccountUser.Size = new System.Drawing.Size(122, 45);
            this.btnAddAccountUser.TabIndex = 13;
            this.btnAddAccountUser.Text = "Thêm";
            this.btnAddAccountUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccountUser
            // 
            this.btnDeleteAccountUser.Location = new System.Drawing.Point(369, 625);
            this.btnDeleteAccountUser.Name = "btnDeleteAccountUser";
            this.btnDeleteAccountUser.Size = new System.Drawing.Size(122, 45);
            this.btnDeleteAccountUser.TabIndex = 14;
            this.btnDeleteAccountUser.Text = "Xóa";
            this.btnDeleteAccountUser.UseVisualStyleBackColor = true;
            this.btnDeleteAccountUser.Click += new System.EventHandler(this.btnDeleteAccountUser_Click);
            // 
            // btnEditAccountUser
            // 
            this.btnEditAccountUser.Location = new System.Drawing.Point(680, 625);
            this.btnEditAccountUser.Name = "btnEditAccountUser";
            this.btnEditAccountUser.Size = new System.Drawing.Size(122, 45);
            this.btnEditAccountUser.TabIndex = 15;
            this.btnEditAccountUser.Text = "Sửa";
            this.btnEditAccountUser.UseVisualStyleBackColor = true;
            // 
            // picAccountFullName
            // 
            this.picAccountFullName.Image = global::App_Cham_Cong.Properties.Resources.icons8_user_25;
            this.picAccountFullName.Location = new System.Drawing.Point(594, 212);
            this.picAccountFullName.Name = "picAccountFullName";
            this.picAccountFullName.Size = new System.Drawing.Size(38, 23);
            this.picAccountFullName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAccountFullName.TabIndex = 9;
            this.picAccountFullName.TabStop = false;
            // 
            // picPassAccountUser
            // 
            this.picPassAccountUser.Image = global::App_Cham_Cong.Properties.Resources.icons8_password_25;
            this.picPassAccountUser.Location = new System.Drawing.Point(594, 155);
            this.picPassAccountUser.Name = "picPassAccountUser";
            this.picPassAccountUser.Size = new System.Drawing.Size(38, 23);
            this.picPassAccountUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPassAccountUser.TabIndex = 6;
            this.picPassAccountUser.TabStop = false;
            // 
            // picAccountUser
            // 
            this.picAccountUser.Image = global::App_Cham_Cong.Properties.Resources.icons8_user_25;
            this.picAccountUser.Location = new System.Drawing.Point(594, 99);
            this.picAccountUser.Name = "picAccountUser";
            this.picAccountUser.Size = new System.Drawing.Size(38, 23);
            this.picAccountUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAccountUser.TabIndex = 3;
            this.picAccountUser.TabStop = false;
            // 
            // AccountManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 761);
            this.Controls.Add(this.panel1);
            this.Name = "AccountManagementForm";
            this.Text = "AccountManagementForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccountFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassAccountUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccountUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAccountUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAccountUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGroupID;
        private System.Windows.Forms.PictureBox picAccountFullName;
        private System.Windows.Forms.TextBox txtAccountFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picPassAccountUser;
        private System.Windows.Forms.TextBox txtPasswordAccountUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvAccountUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.Button btnAddAccountUser;
        private System.Windows.Forms.Button btnEditAccountUser;
        private System.Windows.Forms.Button btnDeleteAccountUser;
    }
}