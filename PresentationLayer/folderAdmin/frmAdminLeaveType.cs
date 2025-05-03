using BusinessLayer;
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

namespace PresentationLayer.folderAdmin
{
    public partial class frmAdminLeaveType : Form
    {
        private LeaveTypeBL leaveTypeBL;
        private List<LeaveTypeDTO> leaveTypes;
        public frmAdminLeaveType()
        {
            InitializeComponent();
            leaveTypeBL = new LeaveTypeBL();

            btnAddType.Click += new EventHandler(btnAddType_Click);

            LoadLeaveTypes();
        }
        private void LoadLeaveTypes()
        {
            try
            {
                // Xóa dữ liệu cũ trong DataGridView
                dgvLeaveTypes.Rows.Clear();

                // Lấy dữ liệu từ cơ sở dữ liệu
                leaveTypes = leaveTypeBL.GetAll();

                // Hiển thị dữ liệu lên DataGridView
                foreach (var type in leaveTypes)
                {
                    int rowIndex = dgvLeaveTypes.Rows.Add();
                    dgvLeaveTypes.Rows[rowIndex].Cells["dgvTypeLeave"].Value = type.TypeName;

                    // Hiển thị số ngày được nghỉ nếu có
                    dgvLeaveTypes.Rows[rowIndex].Cells["dgvAllowedLeave"].Value = 
                        type.AllowedDays.HasValue ? type.AllowedDays.ToString() : "";

                    // Hiển thị ghi chú nếu có
                    dgvLeaveTypes.Rows[rowIndex].Cells["dgvDiscription"].Value =
                        !string.IsNullOrEmpty(type.Description) ? type.Description : "";

                    // Lưu TypeID vào Tag của dòng để sử dụng sau này nếu cần
                    dgvLeaveTypes.Rows[rowIndex].Tag = type.TypeID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem các trường đã được nhập chưa
                if (string.IsNullOrWhiteSpace(txtType.Text))
                {
                    MessageBox.Show("Vui lòng nhập loại nghỉ phép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtType.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAllowed.Text))
                {
                    MessageBox.Show("Vui lòng nhập số ngày được nghỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAllowed.Focus();
                    return;
                }

                // Kiểm tra xem số ngày được nghỉ có phải là số không
                int allowedDays;
                if (!int.TryParse(txtAllowed.Text, out allowedDays))
                {
                    MessageBox.Show("Số ngày được nghỉ phải là một số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAllowed.Focus();
                    txtAllowed.SelectAll();
                    return;
                }

                // Tạo đối tượng LeaveTypeDTO mới
                LeaveTypeDTO newLeaveType = new LeaveTypeDTO
                {
                    TypeName = txtType.Text,
                    AllowedDays = allowedDays,
                    Description = txtDescription.Text
                };

                // Lưu vào database
                bool success = leaveTypeBL.Add(newLeaveType);

                if (success)
                {
                    // Thêm dữ liệu vào DataGridView
                    int rowIndex = dgvLeaveTypes.Rows.Add();
                    dgvLeaveTypes.Rows[rowIndex].Cells["dgvTypeLeave"].Value = txtType.Text;
                    dgvLeaveTypes.Rows[rowIndex].Cells["dgvAllowedLeave"].Value = txtAllowed.Text;
                    dgvLeaveTypes.Rows[rowIndex].Cells["dgvDiscription"].Value = txtDescription.Text;

                    // Xóa dữ liệu trong các TextBox sau khi thêm thành công
                    ClearInputs();

                    // Cập nhật lại dữ liệu từ database để có TypeID mới nhất
                    LoadLeaveTypes();

                    MessageBox.Show("Thêm loại nghỉ phép thành công vào cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể thêm loại nghỉ phép vào cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            txtType.Clear();
            txtAllowed.Clear();
            txtDescription.Clear();
            txtType.Focus();
        }
        private void frmAdminLeaveType_Load(object sender, EventArgs e)
        {

        }

        private void dgvLeaveTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
