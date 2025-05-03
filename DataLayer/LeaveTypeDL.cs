using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataLayer
{
    public class LeaveTypeDL: DataProvider
    {
        public List<LeaveTypeDTO> GetAll()
        {
            List<LeaveTypeDTO> list = new List<LeaveTypeDTO>();
            string sql = "SELECT * FROM LeaveType";
            SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
            while (reader.Read())
            {
                LeaveTypeDTO dto = new LeaveTypeDTO()
                {
                    TypeID = Convert.ToInt32(reader["TypeID"]),
                    TypeName = reader["TypeName"].ToString()
                };

                if (HasColumn(reader, "AllowedDays") && reader["AllowedDays"] != DBNull.Value)
                {
                    dto.AllowedDays = Convert.ToInt32(reader["AllowedDays"]);
                }

                if (HasColumn(reader, "Description") && reader["Description"] != DBNull.Value)
                {
                    dto.Description = reader["Description"].ToString();
                }

                list.Add(dto);
            }
            reader.Close();
            return list;
        }
        // Phương thức kiểm tra xem cột có tồn tại trong SqlDataReader không
        private bool HasColumn(SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }


        public bool Add(LeaveTypeDTO type)
        {
            // Kiểm tra xem cột AllowedDays và Description đã được thêm vào database chưa
            string checkColumnsQuery = @"
                SELECT COUNT(*) 
                FROM INFORMATION_SCHEMA.COLUMNS 
                WHERE TABLE_NAME = 'LeaveType' 
                AND COLUMN_NAME IN ('AllowedDays', 'Description')";

            int columnsExist = (int)MyExecuteScalar(checkColumnsQuery, CommandType.Text);

            // Nếu cả hai cột đã tồn tại
            if (columnsExist == 2)
            {
                string sql = @"
                    INSERT INTO LeaveType(TypeName, AllowedDays, Description) 
                    VALUES(@TypeName, @AllowedDays, @Description)";
                
                var param = new List<SqlParameter>()
                {
                    new SqlParameter("@TypeName", type.TypeName),
                    new SqlParameter("@AllowedDays", (object)type.AllowedDays ?? DBNull.Value),
                    new SqlParameter("@Description", (object)type.Description ?? DBNull.Value)
                };
                
                return MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
            }
            else
            {
                // Sử dụng truy vấn gốc nếu các cột mới chưa tồn tại
                string sql = "INSERT INTO LeaveType(TypeName) VALUES(@TypeName)";
                var param = new List<SqlParameter>()
                {
                    new SqlParameter("@TypeName", type.TypeName)
                };
                return MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
            }
        }

        public bool Delete(int id)
        {
            string sql = "DELETE FROM LeaveType WHERE TypeID=@id";
            var param = new List<SqlParameter>()
            {
                new SqlParameter("@id", id)
            };
            return MyExecuteNonQuery(sql, CommandType.Text, param) > 0;
        }

        // Thêm phương thức này để thực thi các truy vấn đếm hoặc trả về giá trị đơn
        private object MyExecuteScalar(string strConnect, string sql, CommandType cmdType, List<SqlParameter> parameters = null)
        {
            SqlConnection conn = new SqlConnection(strConnect);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = cmdType;

            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.Add(param);
                }
            }

            object result = cmd.ExecuteScalar();
            conn.Close();
            return result;
        }
    }
}