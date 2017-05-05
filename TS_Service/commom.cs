using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TS_Service
{
    public class commom
    {
        //首先设置连接到配置文件组建 Web.config
        static string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;

        //连接数据库
        SqlConnection con = new SqlConnection(connStr);

        public DataSet Lookup_table (string sql)
        {
            con.Open();

            //查找表
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);

            con.Close();
            return ds;
        }

        public int Operate_table(string sql)
        {
            con.Open();

            //操作表
            SqlCommand myco = new SqlCommand(sql, con);
            int flag = myco.ExecuteNonQuery();

            con.Close();
            return flag;
        }
    }
}