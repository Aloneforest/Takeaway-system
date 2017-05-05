using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TS_Service
{
    /// <summary>
    /// TSChangeDishes_chpi_Handler 的摘要说明
    /// </summary>
    public class TSChangeDishes_chpi_Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string fileName = context.Request["fileName"];

            //设置上传文件存储位置
            string fileaddress = @"C:\Users\alone森林\Desktop\通用\c#\ConsoleApplication1\Takeaway system\TS_Service\picture\" + fileName;

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