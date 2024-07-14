namespace App_Cham_Cong.GUI
{
    partial class GroupManagementForm
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
            this.dgvFunctionManagement = new System.Windows.Forms.DataGridView();
            this.GroupIDFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEnable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGroupManagement = new System.Windows.Forms.DataGridView();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupDecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditGroupManagement = new System.Windows.Forms.Button();
            this.btnDeleteGroupManagement = new System.Windows.Forms.Button();
            this.btnAddGroupManagement = new System.Windows.Forms.Button();
            this.txtGroupDecs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGroupManagementName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupManagement)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFunctionManagement);
            this.panel1.Controls.Add(this.dgvGroupManagement);
            this.panel1.Controls.Add(this.btnEditGroupManagement);
            this.panel1.Controls.Add(this.btnDeleteGroupManagement);
            this.panel1.Controls.Add(this.btnAddGroupManagement);
            this.panel1.Controls.Add(this.txtGroupDecs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGroupManagementName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtGroupID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 804);
            this.panel1.TabIndex = 0;
            // 
            // dgvFunctionManagement
            // 
            this.dgvFunctionManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunctionManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupIDFunc,
            this.FunctionID,
            this.isEnable});
            this.dgvFunctionManagement.Location = new System.Drawing.Point(289, 545);
            this.dgvFunctionManagement.Name = "dgvFunctionManagement";
            this.dgvFunctionManagement.RowHeadersWidth = 51;
            this.dgvFunctionManagement.RowTemplate.Height = 24;
            this.dgvFunctionManagement.Size = new System.Drawing.Size(441, 234);
            this.dgvFunctionManagement.TabIndex = 13;
            // 
            // GroupIDFunc
            // 
            this.GroupIDFunc.HeaderText = "Mã Chức Vụ";
            this.GroupIDFunc.MinimumWidth = 6;
            this.GroupIDFunc.Name = "GroupIDFunc";
            this.GroupIDFunc.Width = 125;
            // 
            // FunctionID
            // 
            this.FunctionID.HeaderText = "Giao diện các bảng";
            this.FunctionID.MinimumWidth = 6;
            this.FunctionID.Name = "FunctionID";
            this.FunctionID.Width = 125;
            // 
            // isEnable
            // 
            this.isEnable.HeaderText = "Được Phân Quyền";
            this.isEnable.MinimumWidth = 6;
            this.isEnable.Name = "isEnable";
            this.isEnable.Width = 125;
            // 
            // dgvGroupManagement
            // 
            this.dgvGroupManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupID,
            this.GroupName,
            this.GroupDecs,
            this.UpdateBy,
            this.UpdateTime});
            this.dgvGroupManagement.Location = new System.Drawing.Point(166, 276);
            this.dgvGroupManagement.Name = "dgvGroupManagement";
            this.dgvGroupManagement.RowHeadersWidth = 51;
            this.dgvGroupManagement.RowTemplate.Height = 24;
            this.dgvGroupManagement.Size = new System.Drawing.Size(694, 249);
            this.dgvGroupManagement.TabIndex = 12;
            // 
            // GroupID
            // 
            this.GroupID.HeaderText = "Mã Chức Vụ";
            this.GroupID.MinimumWidth = 6;
            this.GroupID.Name = "GroupID";
            this.GroupID.Width = 125;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Tên Chức Vụ";
            this.GroupName.MinimumWidth = 6;
            this.GroupName.Name = "GroupName";
            this.GroupName.Width = 125;
            // 
            // GroupDecs
            // 
            this.GroupDecs.HeaderText = "Mô Tả Chức Vụ";
            this.GroupDecs.MinimumWidth = 6;
            this.GroupDecs.Name = "GroupDecs";
            this.GroupDecs.Width = 125;
            // 
            // btnEditGroupManagement
            // 
            this.btnEditGroupManagement.Location = new System.Drawing.Point(759, 201);
            this.btnEditGroupManagement.Name = "btnEditGroupManagement";
            this.btnEditGroupManagement.Size = new System.Drawing.Size(110, 43);
            this.btnEditGroupManagement.TabIndex = 11;
            this.btnEditGroupManagement.Text = "Sửa";
            this.btnEditGroupManagement.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGroupManagement
            // 
            this.btnDeleteGroupManagement.Location = new System.Drawing.Point(842, 108);
            this.btnDeleteGroupManagement.Name = "btnDeleteGroupManagement";
            this.btnDeleteGroupManagement.Size = new System.Drawing.Size(110, 43);
            this.btnDeleteGroupManagement.TabIndex = 10;
            this.btnDeleteGroupManagement.Text = "Xóa";
            this.btnDeleteGroupManagement.UseVisualStyleBackColor = true;
            // 
            // btnAddGroupManagement
            // 
            this.btnAddGroupManagement.Location = new System.Drawing.Point(675, 108);
            this.btnAddGroupManagement.Name = "btnAddGroupManagement";
            this.btnAddGroupManagement.Size = new System.Drawing.Size(110, 43);
            this.btnAddGroupManagement.TabIndex = 9;
            this.btnAddGroupManagement.Text = "Thêm";
            this.btnAddGroupManagement.UseVisualStyleBackColor = true;
            // 
            // txtGroupDecs
            // 
            this.txtGroupDecs.Location = new System.Drawing.Point(239, 222);
            this.txtGroupDecs.Name = "txtGroupDecs";
            this.txtGroupDecs.Size = new System.Drawing.Size(343, 22);
            this.txtGroupDecs.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mô tả";
            // 
            // txtGroupManagementName
            // 
            this.txtGroupManagementName.Location = new System.Drawing.Point(239, 164);
            this.txtGroupManagementName.Name = "txtGroupManagementName";
            this.txtGroupManagementName.Size = new System.Drawing.Size(343, 22);
            this.txtGroupManagementName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Chức Vụ";
            // 
            // txtGroupID
            // 
            this.txtGroupID.Location = new System.Drawing.Point(239, 108);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(343, 22);
            this.txtGroupID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Chức Vụ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(356, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 67);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(103, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chức Vụ";
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
            this.UpdateTime.HeaderText = "Thời Gian Cập Nhật";
            this.UpdateTime.MinimumWidth = 6;
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.Width = 125;
            // 
            // GroupManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 800);
            this.Controls.Add(this.panel1);
            this.Name = "GroupManagementForm";
            this.Text = "GroupManagementForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupManagement)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGroupManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupDecs;
        private System.Windows.Forms.Button btnEditGroupManagement;
        private System.Windows.Forms.Button btnDeleteGroupManagement;
        private System.Windows.Forms.Button btnAddGroupManagement;
        private System.Windows.Forms.TextBox txtGroupDecs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGroupManagementName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFunctionManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupIDFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn isEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
    }
}