using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takeaway_system
{
    public class ViewMenu_Load
    {
        public string uname;

        //设置连接到配置文件组建 App.config,获得连接地址
        string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;

        //菜品表
        public DataTable dt;

        public void TSViewMenu_Load(ListBox MenulistBox)
        {
            string handlerurl =
                url + "TSViewMenu_Handler.ashx?uname=" + uname;
            //url + "TSViewMenu_Handler.ashx?uname=he";

            //访问服务器
            string json = HttpHelper.Get(handlerurl);

            if (json == "")
                return;

            dt = Common.JsonHelper.JsonToDataTable(json);

            //向listbox中添加菜品名
            for (int i = 0; i < dt.Rows.Count; i++)
                MenulistBox.Items.Add(dt.Rows[i][0]);
        }

        public void TSViweDish_Click(ListBox MenulistBox, Label label, PictureBox pictureBox)
        {
            if (MenulistBox.SelectedIndex < 0)
                return;

            //获取菜品名
            string name = MenulistBox.Items[MenulistBox.SelectedIndex].ToString();
            name = name.Trim();

            //获取图片文件地址
            string fileaddress = Application.StartupPath + "\\" + name + ".jpg";

            //显示价格
            label.Text = dt.Rows[MenulistBox.SelectedIndex][1].ToString();

            ////判断文件是否存在
            //if (!File.Exists(fileaddress))
            //{
            //    //不存在则从服务器上下载
                string handlerurl =
                    url + "picture/" + name + ".jpg";

            //    WebClient myWebClient = new WebClient();
            //    myWebClient.DownloadFile(handlerurl, name + ".jpg");
            //}

            //显示图片
            //pictureBox.Image = Image.FromFile(fileaddress);
                pictureBox.Image = Image.FromStream(System.Net.WebRequest.Create(handlerurl).GetResponse().GetResponseStream());
        }
    }
}
