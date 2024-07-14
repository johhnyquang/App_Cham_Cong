namespace App_Cham_Cong.GUI
{
    partial class DayShiftForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LateArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EarlyArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(383, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 67);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ca Làm Việc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ShiftID,
            this.ShiftName,
            this.ShiftStartTime,
            this.ShiftEndTime,
            this.LateArrival,
            this.EarlyArrival});
            this.dataGridView1.Location = new System.Drawing.Point(61, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 396);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // ShiftID
            // 
            this.ShiftID.HeaderText = "Mã Ca";
            this.ShiftID.MinimumWidth = 6;
            this.ShiftID.Name = "ShiftID";
            this.ShiftID.Width = 125;
            // 
            // ShiftName
            // 
            this.ShiftName.HeaderText = "Tên Ca";
            this.ShiftName.MinimumWidth = 6;
            this.ShiftName.Name = "ShiftName";
            this.ShiftName.Width = 125;
            // 
            // ShiftStartTime
            // 
            this.ShiftStartTime.HeaderText = "Thời gian vào";
            this.ShiftStartTime.MinimumWidth = 6;
            this.ShiftStartTime.Name = "ShiftStartTime";
            this.ShiftStartTime.Width = 125;
            // 
            // ShiftEndTime
            // 
            this.ShiftEndTime.HeaderText = "Thời gian ra";
            this.ShiftEndTime.MinimumWidth = 6;
            this.ShiftEndTime.Name = "ShiftEndTime";
            this.ShiftEndTime.Width = 125;
            // 
            // LateArrival
            // 
            this.LateArrival.HeaderText = "Số phút trễ";
            this.LateArrival.MinimumWidth = 6;
            this.LateArrival.Name = "LateArrival";
            this.LateArrival.Width = 125;
            // 
            // EarlyArrival
            // 
            this.EarlyArrival.HeaderText = "Số phút sớm";
            this.EarlyArrival.MinimumWidth = 6;
            this.EarlyArrival.Name = "EarlyArrival";
            this.EarlyArrival.Width = 125;
            // 
            // DayShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 526);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "DayShiftForm";
            this.Text = "Ca Làm Việc";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LateArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarlyArrival;
    }
}