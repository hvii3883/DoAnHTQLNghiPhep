namespace PresentationLayer.folderAdmin
{
    partial class frmAdminDashBoard
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
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTypeleave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgDuyetBoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgNgayDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnReject.Location = new System.Drawing.Point(538, 14);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(142, 42);
            this.btnReject.TabIndex = 6;
            this.btnReject.Text = "Từ Chối";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnApprove.Location = new System.Drawing.Point(798, 14);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(142, 42);
            this.btnApprove.TabIndex = 5;
            this.btnApprove.Text = "Chấp Nhận";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "DANH SÁCH NGHỈ PHÉP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnApprove);
            this.panel1.Controls.Add(this.btnReject);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 84);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dgvRequests);
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 391);
            this.panel2.TabIndex = 10;
            // 
            // dgvRequests
            // 
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvEmail,
            this.dgvTypeleave,
            this.dgvFromDate,
            this.dgvToDate,
            this.dvgReason,
            this.dvgDuyetBoi,
            this.dtgNgayDuyet});
            this.dgvRequests.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRequests.Location = new System.Drawing.Point(0, 9);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.RowHeadersWidth = 51;
            this.dgvRequests.RowTemplate.Height = 24;
            this.dgvRequests.Size = new System.Drawing.Size(1015, 382);
            this.dgvRequests.TabIndex = 5;
            this.dgvRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellContentClick_1);
            // 
            // dgvEmail
            // 
            this.dgvEmail.DataPropertyName = "EmpEmail";
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.MinimumWidth = 6;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.Width = 180;
            // 
            // dgvTypeleave
            // 
            this.dgvTypeleave.DataPropertyName = "TypeID";
            this.dgvTypeleave.HeaderText = "Loại nghỉ phép";
            this.dgvTypeleave.MinimumWidth = 6;
            this.dgvTypeleave.Name = "dgvTypeleave";
            this.dgvTypeleave.Width = 130;
            // 
            // dgvFromDate
            // 
            this.dgvFromDate.DataPropertyName = "FromDate";
            this.dgvFromDate.HeaderText = "Từ ngày";
            this.dgvFromDate.MinimumWidth = 6;
            this.dgvFromDate.Name = "dgvFromDate";
            this.dgvFromDate.Width = 125;
            // 
            // dgvToDate
            // 
            this.dgvToDate.DataPropertyName = "ToDate";
            this.dgvToDate.HeaderText = "Đến ngày";
            this.dgvToDate.MinimumWidth = 6;
            this.dgvToDate.Name = "dgvToDate";
            this.dgvToDate.Width = 125;
            // 
            // dvgReason
            // 
            this.dvgReason.DataPropertyName = "Reason";
            this.dvgReason.HeaderText = "Lí do";
            this.dvgReason.MinimumWidth = 6;
            this.dvgReason.Name = "dvgReason";
            this.dvgReason.Width = 170;
            // 
            // dvgDuyetBoi
            // 
            this.dvgDuyetBoi.DataPropertyName = "ApprovedBy";
            this.dvgDuyetBoi.HeaderText = "Duyệt bởi";
            this.dvgDuyetBoi.MinimumWidth = 6;
            this.dvgDuyetBoi.Name = "dvgDuyetBoi";
            this.dvgDuyetBoi.Width = 125;
            // 
            // dtgNgayDuyet
            // 
            this.dtgNgayDuyet.DataPropertyName = "ApproveDate";
            this.dtgNgayDuyet.HeaderText = "Ngày duyệt";
            this.dtgNgayDuyet.MinimumWidth = 6;
            this.dtgNgayDuyet.Name = "dtgNgayDuyet";
            this.dtgNgayDuyet.Width = 110;
            // 
            // frmAdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdminDashBoard";
            this.Text = "frmAdmin1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdmin1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTypeleave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgDuyetBoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgNgayDuyet;
    }
}