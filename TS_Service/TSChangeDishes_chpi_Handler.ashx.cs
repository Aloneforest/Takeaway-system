using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TS_Service
{
    /// <summary>
    /// TSChangeDishes_chpi_Handler 的摘要说明
    /// </summary>
    public class TSChangeDishes_chpi_Handler : IHttpHandler
    {
        string fileaddress = ConfigurationManager.ConnectionStrings["fad"].ConnectionString;
       
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string fileName = context.Request["fileName"];

            //设置上传文件存储位置
            fileaddress = @fileaddress + fileName;

            HttpPostedFile file = HttpContext.Current.Request.Files[0];
            file.SaveAs(fileaddress);

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