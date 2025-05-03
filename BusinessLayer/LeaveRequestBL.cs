using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class LeaveRequestBL
    {
        private LeaveRequestDL dal = new LeaveRequestDL();
        private EmployeeDL employeeDL = new EmployeeDL();
        EmailService emailService = new EmailService();

        public bool SendRequest(LeaveRequestDTO r) => dal.SendRequest(r);
        public List<LeaveRequestDTO> GetAllRequests() => dal.GetAllRequests();
        public bool UpdateStatus(int id, int status, string approver) => dal.UpdateStatus(id, status, approver);
        public Dictionary<int, int> GetMonthlyStatistics() => dal.GetMonthlyStatistics();

        public void SendLeaveRequestEmail(string email, DateTime from, DateTime to,bool sendEmail)
        {
            if (sendEmail )
            {
                // Gọi DAL để lấy tên nhân viên
                var emp = employeeDL.GetEmployeeByEmail(email);
                if (emp != null)
                {
                    string subject = "Xác nhận đăng ký nghỉ phép";
                    string body = $"Chào {emp.FullName},\nBạn đã đăng ký nghỉ từ {from:dd/MM/yyyy} đến {to:dd/MM/yyyy}.";
                    emailService.SendEmail(emp.Email, subject, body);
                }
            }
        }
    }

}

