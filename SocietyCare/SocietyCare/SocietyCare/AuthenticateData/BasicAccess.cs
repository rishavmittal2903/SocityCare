using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;

namespace SocietyCare.AuthenticateData
{
    public sealed class BasicAccess
    {
        public static string connectionString=string.Empty;
        public static Database sqlDatabase;
        public static DbConnection objCon;
        public static Database CreateDataBase(string connectionString)
        {
            sqlDatabase = new SqlDatabase(connectionString);
            return sqlDatabase;
        }
        public static DbConnection CreateConnection()
        {
            objCon= sqlDatabase.CreateConnection();
            return objCon;
        }

        public static void OpenConnection()
        {
            objCon.Open();

        }
        public static void CloseConnection()
        {
            objCon.Close();

        }
    }
}
