using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TS_Service
{
    /// <summary>
    /// TSRemoveDishes_Handler 的摘要说明
    /// </summary>
    public class TSRemoveDishes_Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string uname = context.Request["uname"];
            string name = context.Request["name"];

            string sql = "select * from 菜品表 where name='" + name + "' and uname='" + uname + "'";

            commom com = new commom();
            DataSet ds = com.Lookup_table(sql);

            if (ds.Tables[0].Rows.Count == 0)
            {
                //没有该菜品
                context.Response.Write("false");

                return;
            }

            sql = "delete from 菜品表 where name='" + name + "' and uname='" + uname + "'";
            //string sql = "delete from 菜品表 where name='wsx' and uname='he'";

            //删除菜品
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