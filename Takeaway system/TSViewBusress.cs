using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takeaway_system
{
    public partial class TSViewBusress : Form
    {
        public string uname;

        //设置连接到配置文件组建 App.config,获得连接地址
        string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;

        //商家表
        DataTable dt;

        public TSViewBusress()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void TSViewBusress_Load(object sender, EventArgs e)
        {
            string handlerurl =
                url + "TSViewBusress_Handler.ashx";
            //url + "TSViewMenu_Handler.ashx?uname=he";

            //访问服务器
            string json = HttpHelper.Get(handlerurl);

            if (json == "")
                return;

            dt = Common.JsonHelper.JsonToDataTable(json);

            //向listbox中添加商家名
            for (int i = 0; i < dt.Rows.Count; i++)
                BusinesslistBox.Items.Add(dt.Rows[i][0]);
        }

        private void ViweBusress_Click(object sender, EventArgs e)
        {
            int a=0;
            while(this.Controls.Count != 1)
            {
                if (this.Controls[a].Name != "BusinesslistBox")
                    this.Controls[a].Dispose();
                else
                    a++;
            }

            if (BusinesslistBox.SelectedIndex < 0)
                    return;

            //获取商家名
            string name = BusinesslistBox.Items[BusinesslistBox.SelectedIndex].ToString();
            name = name.Trim();

            //TSViewMenu from = new TSViewMenu();
            //from.uname = name;
            //from.Show();

            string handlerurl =
                url + "TSViewMenu_Handler.ashx?uname=" + name;

            //访问服务器
            string json = HttpHelper.Get(handlerurl);

            if (json == "")
                return;

            dt = Common.JsonHelper.JsonToDataTable(json);


            int p=-1, q=0, chx=200, chy=200;
            //向listbox中添加菜品名
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                p++;
                if (p == 3)
                {
                    p = 0;
                    q++;
                }
                Label la1_4 = new Label();
                la1_4.Top = 182 + q * chy;
                la1_4.Left = 328 + p * chx;
                la1_4.Text = dt.Rows[i][1].ToString().Trim();
                this.Controls.Add(la1_4);
                Label la1_3 = new Label();
                la1_3.Top = 182 + q * chy;
                la1_3.Left = 287 + p * chx;
                la1_3.Text = "价格:";
                this.Controls.Add(la1_3);
                Label la1_2 = new Label();
                la1_2.Top = 182 + q * chy;
                la1_2.Left = 234 + p * chx;
                la1_2.Text = dt.Rows[i][0].ToString().Trim();
                this.Controls.Add(la1_2);
                Label la1_1 = new Label();
                la1_1.Top = 182 + q * chy;
                la1_1.Left = 193 + p * chx;
                la1_1.Text = "菜名:";
                this.Controls.Add(la1_1);
                PictureBox pb = new PictureBox();
                pb.Name = "pb"+i;
                pb.Top = 12 + q * chy;
                pb.Left = 195 + p * chx;
                pb.Size = new Size(174, 154);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pb);
                handlerurl =
                    url + "picture/" + la1_2.Text + ".jpg";
                ((PictureBox)this.Controls.Find("pb"+i, true)[0]).Image = Image.FromStream(System.Net.WebRequest.Create(handlerurl).GetResponse().GetResponseStream());
            }
        }
    }
}
