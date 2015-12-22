using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TestDTToView.SQL
{
    public class SQLDb
    {
        string conStr = ConfigurationManager.ConnectionStrings["SQLCon"].ToString();

        public DataSet GetDSByQuery(string cmd)
        {
            DataSet ds = new DataSet();

            using(SqlConnection con = new SqlConnection(conStr))
            {
                using(SqlDataAdapter adp = new SqlDataAdapter(cmd, con))
                {
                    adp.Fill(ds);
                }
            }

            return ds;
        }

        public DataTable GetDTByQuery(string cmd)
        {
            DataTable dt = new DataTable();

            using(SqlConnection con = new SqlConnection(conStr))
            {
                using(SqlDataAdapter adp = new SqlDataAdapter(cmd, con))
                {
                    adp.Fill(dt);
                }
            }

            return dt;
        }

    }
}