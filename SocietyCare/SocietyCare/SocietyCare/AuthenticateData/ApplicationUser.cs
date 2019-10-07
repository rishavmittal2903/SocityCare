using SocietyCare.Contracts;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace SocietyCare.AuthenticateData
{
    public class ApplicationUser
    {
        public ApplicationUser(string conn)
        {
           BasicAccess.CreateDataBase(conn);
        }

       
        public byte[] getZwaveData()
        {
            DataTable dataTable = new DataTable();
            byte[] response = null;
            BasicAccess.CreateConnection();
            BasicAccess.OpenConnection();
            DbTransaction objDbTransaction = BasicAccess.objCon.BeginTransaction(IsolationLevel.ReadUncommitted);
            DbCommand cmd = BasicAccess.sqlDatabase.GetSqlStringCommand(" Select * from core.peripheral");

            SqlDataReader dr = (SqlDataReader)BasicAccess.sqlDatabase.ExecuteReader(cmd, objDbTransaction);

            StringBuilder sb = new StringBuilder();

            while (dr.Read())
            {
                sb.Append(Convert.ToString(dr[0]));
                sb.Append("");
            }
            BasicAccess.objCon.Close();

            return response;
        }
        public int Add(UserDetails user)
        {
            return 0;
        }

        public UserDetails GetByEmailAndPassword(string userId, string password)
        {
            DataTable dataTable = new DataTable();
            byte[] response = null;
            BasicAccess.CreateConnection();
            BasicAccess.OpenConnection();
            DbTransaction objDbTransaction = BasicAccess.objCon.BeginTransaction(IsolationLevel.ReadUncommitted);
            DbCommand cmd = BasicAccess.sqlDatabase.GetSqlStringCommand(" Select * from UserDetails where UserId=@UserId and password=@password");
            cmd.Parameters.Add(new SqlParameter("@UserId", SqlDbType.VarChar) { Value = userId });
            cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar) { Value = password });
            SqlDataReader dr = (SqlDataReader)BasicAccess.sqlDatabase.ExecuteReader(cmd, objDbTransaction);
            while (dr.Read())
            {
                
            }
            BasicAccess.objCon.Close();
            return null;

        }

        public UserDetails GetByEmail(string email)
        {
            return null;
        }

        public bool SetActive(string email, string jwttoken)
        {
            return false;
        }

        public bool UpdatePasswordByEmail(string email, string newpassword, string jwttoken)
        {
            return false;

        }
    }
}
