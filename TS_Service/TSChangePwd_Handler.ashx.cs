using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TS_Service
{
    /// <summary>
    /// TSChangePwd_Handler 的摘要说明
    /// </summary>
    public class TSChangePwd_Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string uname = context.Request["uname"];
            string pow = context.Request["pow"];
            string id = context.Request["id"];

            string sql;

            if(id == "1")
                sql = "update 用户表 set pow='" + pow + "' where uname='" + uname + "'";
            else
                sql = "update 商家表 set pow='" + pow + "' where uname='" + uname + "'";

            commom com = new commom();
            int flag = com.Operate_table(sql);

            if (flag == 0)
                context.Response.Write("false");
            else
                context.Response.Write("true");
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