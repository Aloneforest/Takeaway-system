using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TS_Service
{
    /// <summary>
    /// TSPlaceOrder_Handler 的摘要说明
    /// </summary>
    public class TSPlaceOrder_Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //获取参数
            string uname = context.Request["uname"];
            string user_name = context.Request["user_name"];
            string menu_name = context.Request["menu_name"];
            string num = context.Request["num"];
            string address = context.Request["address"];
            string price = context.Request["price"];

            //添加菜品
            string sql = "insert into 订单表 values ('" + uname + "','" + user_name + "','" + menu_name + "'," + num + "," + price + ",'" + address + "')";
            
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