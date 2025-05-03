namespace PresentationLayer.folderAdmin
{
    partial class frmAdminLeaveType
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLeaveTypes = new System.Windows.Forms.DataGridView();
            this.dgvTypeLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAllowedLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAllowed = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leave Types";
            // 
            // dgvLeaveTypes
            // 
            this.dgvLeaveTypes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLeaveTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTypeLeave,
            this.dgvAllowedLeave,
            this.dgvDiscription});
            this.dgvLeaveTypes.Location = new System.Drawing.Point(12, 132);
            this.dgvLeaveTypes.Name = "dgvLeaveTypes";
            this.dgvLeaveTypes.RowHeadersWidth = 51;
            this.dgvLeaveTypes.RowTemplate.Height = 24;
            this.dgvLeaveTypes.Size = new System.Drawing.Size(1016, 326);
            this.dgvLeaveTypes.TabIndex = 1;
            this.dgvLeaveTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeaveTypes_CellContentClick);
            // 
            // dgvTypeLeave
            // 
            this.dgvTypeLeave.HeaderText = "Loại nghỉ phép";
            this.dgvTypeLeave.MinimumWidth = 6;
            this.dgvTypeLeave.Name = "dgvTypeLeave";
            this.dgvTypeLeave.Width = 300;
            // 
            // dgvAllowedLeave
            // 
            this.dgvAllowedLeave.HeaderText = "Số ngày được nghỉ";
            this.dgvAllowedLeave.MinimumWidth = 6;
            this.dgvAllowedLeave.Name = "dgvAllowedLeave";
            this.dgvAllowedLeave.Width = 300;
            // 
            // dgvDiscription
            // 
            this.dgvDiscription.HeaderText = "Ghi Chú";
            this.dgvDiscription.MinimumWidth = 6;
            this.dgvDiscription.Name = "dgvDiscription";
            this.dgvDiscription.Width = 416;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(686, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Allowed";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(75, 78);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(186, 31);
            this.txtType.TabIndex = 5;
            // 
            // txtAllowed
            // 
            this.txtAllowed.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllowed.Location = new System.Drawing.Point(411, 78);
            this.txtAllowed.Name = "txtAllowed";
            this.txtAllowed.Size = new System.Drawing.Size(201, 31);
            this.txtAllowed.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(798, 81);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(191, 31);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.ForeColor = System.Drawing.Color.White;
            this.btnAddType.Location = new System.Drawing.Point(798, 20);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(156, 38);
            this.btnAddType.TabIndex = 8;
            this.btnAddType.Text = "ADD NEW";
            this.btnAddType.UseVisualStyleBackColor = false;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // frmAdminLeaveType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 470);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAllowed);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLeaveTypes);
            this.Controls.Add(this.label1);
            this.Name = "frmAdminLeaveType";
            this.Text = "frmAdminLeaveType";
            this.Load += new System.EventHandler(this.frmAdminLeaveType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLeaveTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAllowed;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTypeLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAllowedLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiscription;
    }
}