using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion.Core
{
    // we define SQL commands in class level 

    public class PromotionCore
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        int ReturnValueint;
        object ReturnValueobj;

        public PromotionCore()
        {
            con = new SqlConnection(CreateConnection());
            // we can also write like that con = new SqlConnection("Data source = DESKTOP-57R498V\\SQLEXPRESS01 ; initial catalog = RegistrationDraw ; user id = sa ; password = 1;")
        }
        #region for SQL connection ..
        string CreateConnection()
        {
            SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();
            build.DataSource = "DESKTOP-57R498V\\SQLEXPRESS01";
            build.InitialCatalog = "RegistrationDraw"; // this is database name
            build.UserID = "sa";
            build.Password = "1";
            return build.ConnectionString;
        }

        #endregion
        #region Set SQL connection
        public void SetConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)

                con.Open();

            else
                con.Close();
        }
        #endregion
        #region SQL insert update delete commands
        public int InsertUpdateDelete(SqlCommand cmd)
        {
            cmd.Connection = con; // dont forget to sample this!!
            SetConnection();
            ReturnValueint = cmd.ExecuteNonQuery();
            SetConnection();
            return ReturnValueint;
        }
        #endregion
        #region For list
        public SqlDataReader List(SqlCommand cmd)
        {
            cmd.Connection = con;
            SetConnection();
            return cmd.ExecuteReader(); // we will close connection 
        }
        #endregion
        #region for only a column what we do...
        public object GetColumn(SqlCommand cmd)
        {
            cmd.Connection = con; 
            SetConnection();
            ReturnValueobj = cmd.ExecuteScalar();
            SetConnection();
            return ReturnValueobj;
        }
        #endregion


    }
}
