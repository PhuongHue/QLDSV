using BatLoi;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoi
{
    class KetNoiDB
    {
        public SqlConnection SqlConnection { get; set; } = new SqlConnection();
        public string Server { get; set; } = "";
        public string DataBase { get; set; } = "QLDSV";
        public string LoginName { get; set; } = "";
        public string Password { get; set; } = "";
        public string UserName { get; set; } = "";
        public string FullName { get; set; } = "";
        public string GroupId { get; set; } = "";
        public bool Ready { get; set; } = false;

        public void NewSqlConnection()
        {
            this.SqlConnection = new SqlConnection(this.GetConnectionString());
        }
        public void Open()
        {
            this.SqlConnection.Open();
        }
        public string GetConnectionString()
        {
            return $"server={Server};database={DataBase};user id={LoginName};password={Password}";
        }

        public void GetLoginInfomation()
        {
            string sql = "EXEC SP_DANGNHAP " + this.LoginName;
            SqlCommand sqlCommand = new SqlCommand(sql, this.SqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            this.UserName = sqlDataReader.GetValue(0).ToString();
            this.FullName = sqlDataReader.GetValue(1).ToString();
            this.GroupId = sqlDataReader.GetValue(2).ToString();
            sqlDataReader.Close();
        }
        public SqlDataReader ExcuteSP(String SPName)
        {
            try
            {
                string sql = $"DECLARE @return_value int EXEC @return_value = {SPName} SELECT 'Return Value' = @return_value";
                SqlCommand sqlCommand = new SqlCommand(sql, this.SqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                return sqlDataReader;
            }
            catch (SqlException)
            {

                throw;
            }
        }
        public string ConnectServer()
        {
            try
            {
                if (SqlConnection.State == System.Data.ConnectionState.Open) SqlConnection.Close();
                this.SqlConnection.Open();
                this.GetLoginInfomation();
                this.Ready = true;
                return "Kết nối thành công!";
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}

