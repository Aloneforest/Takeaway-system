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
    /// TSAdddishes_Handler 的摘要说明
    /// </summary>
    public class TSAdddishes_Handler : IHttpHandler
    {
        //设置连接到配置文件组建 Web.config
        string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        string fileaddress = ConfigurationManager.ConnectionStrings["fad"].ConnectionString;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //获取参数
            string DishName = context.Request["DishName"];
            string Price = context.Request["Price"];
            string fileName = context.Request["fileName"];
            string uname = context.Request["uname"];

            //设置上传文件存储位置
            fileaddress = @fileaddress + fileName;

            string sql = "select * from 菜品表 where name = '" + DishName + "'";

            ////查找菜品表
            DataSet ds = new DataSet();

            commom com = new commom();
            ds = com.Lookup_table(sql);


            //判断菜品是否以存在
            if (ds.Tables[0].Rows.Count != 0)
            {
                //如果读到相同的用户名 则提示 用户名已存在
                context.Response.Write("false");

                return;
            }

            //添加菜品
            sql = "insert into 菜品表 values ('" + DishName + "', " + Price + ", '" + fileaddress + "', '" + uname + "')";

            int flag = com.Operate_table(sql);

            //存储上传文件
            HttpPostedFile file = HttpContext.Current.Request.Files[0];
            file.SaveAs(fileaddress); 

            if(flag == 0)
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