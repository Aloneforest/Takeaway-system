using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TS_Service
{
    /// <summary>
    /// TSRemoveOrder_Handler 的摘要说明
    /// </summary>
    public class TSRemoveOrder_Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string id = context.Request["id"];

            string sql = "select * from 订单表 where id=" + id;

            commom com = new commom();
            DataSet ds = com.Lookup_table(sql);

            if (ds.Tables[0].Rows.Count == 0)
            {
                //没有该订单
                context.Response.Write("false");

                return;
            }

            sql = "delete from 订单表 where id=" + id;

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