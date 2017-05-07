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
    public partial class TSRemoveDishes : Form
    {
        public string uname = "he";

        //设置连接到配置文件组建 App.config,获得连接地址
        string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;

        ViewMenu_Load f = new ViewMenu_Load();

        public TSRemoveDishes()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void TSRemoveDishes_Load(object sender, EventArgs e)
        {
            f.uname = uname;
            f.TSViewMenu_Load(MenulistBox);
        }

        private void uploadpicture_Click(object sender, EventArgs e)
        {
            //获取菜品名
            if (MenulistBox.SelectedIndex == -1)
            {
                MessageBox.Show("请先选择菜品");
                return;
            }

            string name = MenulistBox.Items[MenulistBox.SelectedIndex].ToString();
            name = name.Trim();

            //创建url
            string handlerurl =
                url + "TSRemoveDishes_Handler.ashx?name=" + name + "&uname=" + uname;

            //访问服务器
            string result = HttpHelper.Get(handlerurl);

            //判断更改是否成功
            if (result == "true")
                MessageBox.Show("success");
            else
                MessageBox.Show("err");
        }
    }
}
