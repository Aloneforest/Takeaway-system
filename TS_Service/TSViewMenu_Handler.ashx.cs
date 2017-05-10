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
    /// TSViewMenu_Handler 的摘要说明
    /// </summary>
    public class TSViewMenu_Handler : IHttpHandler
    {

        //首先设置连接到配置文件组建 Web.config
        string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //获取输入的用户名、密码和身份
            string uname = context.Request["uname"];

            //创建sql语句
            string sql = "select * from 菜品表 where uname = '" + uname + "'";

            //从数据库获取值
            DataSet ds = new DataSet();
            commom com = new commom();
            ds = com.Lookup_table(sql);

            string json = Common.JsonHelper.DataSetToJson(ds.Tables[0]);
            context.Response.Write(json);
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