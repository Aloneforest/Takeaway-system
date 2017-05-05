using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TS_Service
{
    /// <summary>
    /// TSChangeDishes_Handler 的摘要说明
    /// </summary>
    public class TSChangeDishes_Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string chprice = context.Request["chprice"];
            string name = context.Request["name"];

            string sql = "update 菜品表 set price=" + chprice + " where name='" + name + "'";
            //string sql = "update 菜品表 set price=100 where name='asd'";
            
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