using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TS_Service
{
    /// <summary>
    /// TSLogin_Handler 的摘要说明
    /// </summary>
    public class TSLogin_Handler : IHttpHandler
    {

        //首先设置连接到配置文件组建 Web.config
        string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //获取输入的用户名、密码和身份
            string uname = context.Request["uname"];
            string pwd = context.Request["pwd"];
            string id = context.Request["id"];
            //string pwd = "123";

            //连接数据库
            SqlConnection con = new SqlConnection(connStr);

            //创建sql语句
            string sql;
            if(id == "1")
                sql = "select * from 用户表 where uname = '" + uname + "'";
            else
                sql = "select * from 商家表 where uname = '" + uname + "'";

            //从数据库获取值
            DataSet ds = new DataSet();
            commom com = new commom();
            ds = com.Lookup_table(sql);

            //判断用户是否存在
            if (ds.Tables[0].Rows.Count != 0)
            {
                //处理获取的密码（去首尾空格）
                string _pwd = (string)ds.Tables[0].Rows[0][1];
                _pwd = _pwd.Trim();

                //判断密码是否匹配
                if (pwd == _pwd)
                    context.Response.Write("true");
                else
                    context.Response.Write("false");
            }
            else
            {
                context.Response.Write("false");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}