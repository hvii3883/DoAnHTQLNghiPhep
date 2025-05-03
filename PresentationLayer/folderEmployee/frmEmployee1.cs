using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer.folderEmployee
{
    public partial class frmEmployee1 : Form
    {
        public string logEmail;
        public frmEmployee1(string email)
        {
            InitializeComponent();
            logEmail = email;
        }
        private void LoadLeaveInfo()
        {
            LeaveInfoBL bl = new LeaveInfoBL();
            LeaveInfoDTO info = bl.GetLeaveInfoByEmail(logEmail);

            if (info != null)
            {
                txtName.Text = info.FullName;
                txtEmail.Text= info.Email;
                txtTong.Text = info.TotalLeaveDays.ToString();
                
                txtDaNghi.Text = info.DaysTaken.ToString();
                txtNgayCon.Text = info.DaysRemaining.ToString();
                if(info.DaysTaken > info.TotalLeaveDays)
                {
                    lbWarning.Text= "Bạn đã nghỉ quá số ngày quy định!";
                    lbWarning.ForeColor = Color.Red;
                }
                else
                {
                    lbWarning.Text = "";
                }
            }
            
            else
            {
                MessageBox.Show("Không tìm thấy thông tin ngày nghỉ.");
            }
        }


        private void frmEmployee1_Load(object sender, EventArgs e)
        {
            LoadLeaveInfo();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadLeaveInfo();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
