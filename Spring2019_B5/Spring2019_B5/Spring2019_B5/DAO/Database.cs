using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Spring2019_B5.DAO
{
    class Database
    {
        internal static SqlConnection getConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Spring19"].ToString();
            return new SqlConnection(strCon);
        }
        internal static DataTable getDataSql(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, getConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet(); // database Cache
            ds.Clear();
            da.Fill(ds);
            return ds.Tables[0];
        }
        internal static void Execute(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, getConnection());
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
