using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TS_Service
{
    /// <summary>
    /// TSViewOrder_Handler 的摘要说明
    /// </summary>
    public class TSViewOrder_Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //获取输入的用户名、密码和身份
            string uname = context.Request["uname"];
            string id = context.Request["id"];

            //创建sql语句
            string sql;
            if(id == "1")
                sql = "select * from 订单表 where user_name = '" + uname + "'";
            else
                sql = "select * from 订单表 where busi_name = '" + uname + "'";

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