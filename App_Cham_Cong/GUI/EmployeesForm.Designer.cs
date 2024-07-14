namespace App_Cham_Cong.GUI
{
    partial class EmployeesForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBirthdayEmployee = new System.Windows.Forms.DateTimePicker();
            this.txtSalaryEmployee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDayOfWork = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboGroupID = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Of_Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayOfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditEmployee);
            this.panel1.Controls.Add(this.btnDeleteEmployee);
            this.panel1.Controls.Add(this.btnAddEmployee);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.cboGroupID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpDayOfWork);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSalaryEmployee);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpBirthdayEmployee);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmployeeName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmployeeID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 753);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(339, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 67);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(72, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(238, 107);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(343, 22);
            this.txtEmployeeID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã nhân viên";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(238, 165);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(343, 22);
            this.txtEmployeeName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày Sinh";
            // 
            // dtpBirthdayEmployee
            // 
            this.dtpBirthdayEmployee.Location = new System.Drawing.Point(238, 227);
            this.dtpBirthdayEmployee.Name = "dtpBirthdayEmployee";
            this.dtpBirthdayEmployee.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthdayEmployee.TabIndex = 10;
            // 
            // txtSalaryEmployee
            // 
            this.txtSalaryEmployee.Location = new System.Drawing.Point(238, 294);
            this.txtSalaryEmployee.Name = "txtSalaryEmployee";
            this.txtSalaryEmployee.Size = new System.Drawing.Size(343, 22);
            this.txtSalaryEmployee.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lương cơ bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày vào làm";
            // 
            // dtpDayOfWork
            // 
            this.dtpDayOfWork.Location = new System.Drawing.Point(238, 364);
            this.dtpDayOfWork.Name = "dtpDayOfWork";
            this.dtpDayOfWork.Size = new System.Drawing.Size(200, 22);
            this.dtpDayOfWork.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(617, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Chức vụ";
            // 
            // cboGroupID
            // 
            this.cboGroupID.FormattingEnabled = true;
            this.cboGroupID.Location = new System.Drawing.Point(738, 107);
            this.cboGroupID.Name = "cboGroupID";
            this.cboGroupID.Size = new System.Drawing.Size(121, 24);
            this.cboGroupID.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.Date_Of_Birth,
            this.EmployeeSalary,
            this.DayOfWork,
            this.GroupID,
            this.UpdateBy,
            this.UpdateTime});
            this.dataGridView1.Location = new System.Drawing.Point(38, 413);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "Mã nhân viên";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Width = 125;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Tên nhân viên";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 125;
            // 
            // Date_Of_Birth
            // 
            this.Date_Of_Birth.HeaderText = "Ngày Sinh";
            this.Date_Of_Birth.MinimumWidth = 6;
            this.Date_Of_Birth.Name = "Date_Of_Birth";
            this.Date_Of_Birth.Width = 125;
            // 
            // EmployeeSalary
            // 
            this.EmployeeSalary.HeaderText = "Lương cơ bản";
            this.EmployeeSalary.MinimumWidth = 6;
            this.EmployeeSalary.Name = "EmployeeSalary";
            this.EmployeeSalary.Width = 125;
            // 
            // DayOfWork
            // 
            this.DayOfWork.HeaderText = "Ngày vào làm";
            this.DayOfWork.MinimumWidth = 6;
            this.DayOfWork.Name = "DayOfWork";
            this.DayOfWork.Width = 125;
            // 
            // GroupID
            // 
            this.GroupID.HeaderText = "Chức vụ";
            this.GroupID.MinimumWidth = 6;
            this.GroupID.Name = "GroupID";
            this.GroupID.Width = 125;
            // 
            // UpdateBy
            // 
            this.UpdateBy.HeaderText = "Cập nhật bởi";
            this.UpdateBy.MinimumWidth = 6;
            this.UpdateBy.Name = "UpdateBy";
            this.UpdateBy.Width = 125;
            // 
            // UpdateTime
            // 
            this.UpdateTime.HeaderText = "Thời gian cập nhật";
            this.UpdateTime.MinimumWidth = 6;
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.Width = 125;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(38, 638);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(110, 43);
            this.btnAddEmployee.TabIndex = 19;
            this.btnAddEmployee.Text = "Thêm";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(201, 638);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(110, 43);
            this.btnDeleteEmployee.TabIndex = 20;
            this.btnDeleteEmployee.Text = "Xóa";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(360, 638);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(110, 43);
            this.btnEditEmployee.TabIndex = 21;
            this.btnEditEmployee.Text = "Sửa";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 754);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBirthdayEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalaryEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboGroupID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDayOfWork;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Of_Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOfWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
    }
}