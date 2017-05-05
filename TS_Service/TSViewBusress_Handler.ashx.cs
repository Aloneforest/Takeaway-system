using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TS_Service
{
    /// <summary>
    /// TSViewBusress_Handler 的摘要说明
    /// </summary>
    public class TSViewBusress_Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string chprice = context.Request["chprice"];
            string name = context.Request["name"];

            string sql = "select uname from 商家表";

            commom com = new commom();
            DataSet ds = com.Lookup_table(sql);

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