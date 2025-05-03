using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LeaveRequestDL:DataProvider
    {
        public bool SendRequest(LeaveRequestDTO r)
        {
            string sql = "INSERT INTO LeaveRequest(EmpEmail, TypeID, FromDate, ToDate, Reason, Status) VALUES (@EmpEmail, @TypeID, @FromDate, @ToDate, @Reason, 0)";
            var param = new List<SqlParameter>()
        {
            new SqlParameter("@EmpEmail", r.EmpEmail),
            new SqlParameter("@TypeID", r.TypeID),
            new SqlParameter("@FromDate", r.FromDate),
            new SqlParameter("@ToDate", r.ToDate),
            new SqlParameter("@Reason", r.Reason)
        };
            return MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }

        public List<LeaveRequestDTO> GetAllRequests()
        {
            
            List<LeaveRequestDTO> list = new List<LeaveRequestDTO>();
            string sql = "SELECT * FROM LeaveRequest";
            SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
            while (reader.Read())
            {
                list.Add(new LeaveRequestDTO()
                {
                    EmpEmail = reader["EmpEmail"].ToString(),
                    TypeID = Convert.ToInt32(reader["TypeID"]),
                    FromDate = Convert.ToDateTime(reader["FromDate"]),
                    ToDate = Convert.ToDateTime(reader["ToDate"]),
                    Reason = reader["Reason"].ToString(),
                    Status = Convert.ToInt32(reader["Status"]),
                    ApprovedBy = reader["ApprovedBy"] == DBNull.Value ? null : reader["ApprovedBy"].ToString(),
                    ApproveDate = reader["ApproveDate"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["ApproveDate"])
                });
            }
            reader.Close();
            return list;
        }

        public bool UpdateStatus(int requestId, int status, string approvedBy)
        {
            string sql = "UPDATE LeaveRequest SET Status=@status, ApprovedBy=@approvedBy, ApproveDate=GETDATE() WHERE RequestID=@id";
            var param = new List<SqlParameter>()
        {
            new SqlParameter("@status", status),
            new SqlParameter("@approvedBy", approvedBy),
            new SqlParameter("@id", requestId)
        };
            return MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }

        public Dictionary<int, int> GetMonthlyStatistics()
        {
            Dictionary<int, int> stats = new Dictionary<int, int>();
            string sql = @"
        SELECT MONTH(FromDate) AS Month, COUNT(*) AS Count
        FROM LeaveRequest
        WHERE YEAR(FromDate) = YEAR(GETDATE())
        GROUP BY MONTH(FromDate)
        ORDER BY Month";

            SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
            while (reader.Read())
            {
                int month = Convert.ToInt32(reader["Month"]);
                int count = Convert.ToInt32(reader["Count"]);
                stats[month] = count;
            }
            reader.Close();
            return stats;
        }
    }
}
