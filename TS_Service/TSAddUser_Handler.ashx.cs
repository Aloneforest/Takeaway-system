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
    /// TSAddUser_Handler 的摘要说明
    /// </summary>
    public class TSAddUser_Handler : IHttpHandler
    {

        //首先设置连接到配置文件组建 Web.config
        string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //获取输入的用户名和密码
            string uname = context.Request["uname"];
            string pwd = context.Request["pwd"];
            string id = context.Request["id"];

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

            //如果读到数据了,说明 数据库中已存在 文本框中输入的用户名
            if (ds.Tables[0].Rows.Count != 0)
            {
                //如果读到相同的用户名 则提示 用户名已存在
                context.Response.Write("false");
                
                return;
            }

            //创建sql语句
            if (id == "1")
                sql = "insert into 用户表 values ('" + uname + "', '" + pwd + "')";
            else
                sql = "insert into 商家表 values ('" + uname + "', '" + pwd + "')";

            //执行sql语句
            int flag = com.Operate_table(sql);
            
            //判断sql语句是否执行成功
            if(flag != 0)
                context.Response.Write("true");
            else
                context.Response.Write("false");

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