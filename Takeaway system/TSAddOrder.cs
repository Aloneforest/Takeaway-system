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
    public partial class TSAddOrder : Form
    {
        //用户名
        public string uname;

        //设置连接到配置文件组建 App.config,获得连接地址
        string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;

        //商家表
        DataTable dt;

        public TSAddOrder()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void TSPlaceOrder_Load(object sender, EventArgs e)
        {
            //创建url
            string handlerurl =
                url + "TSViewBusress_Handler.ashx";

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
            if (BusinesslistBox.SelectedIndex < 0)
                return;

            //获取商家名
            string name = BusinesslistBox.Items[BusinesslistBox.SelectedIndex].ToString();
            name = name.Trim();

            MenulistBox.Items.Clear();

            //添加菜品表
            ViewMenu_Load f = new ViewMenu_Load();
            f.uname = name;
            f.TSViewMenu_Load(MenulistBox);
            dt = f.dt;
        }

        private void addpicture_Click(object sender, EventArgs e)
        {
            //获取商家名
            if (BusinesslistBox.SelectedIndex == -1)
            {
                MessageBox.Show("请先选择商家");
                return;
            }

            string user_name = BusinesslistBox.Items[BusinesslistBox.SelectedIndex].ToString();
            user_name = user_name.Trim();

            //获取菜品名
            if (MenulistBox.SelectedIndex == -1)
            {
                MessageBox.Show("请先选择菜品");
                return;
            }

            string menu_name = MenulistBox.Items[MenulistBox.SelectedIndex].ToString();
            menu_name = menu_name.Trim();

            //获取数量
            if (textnum.Text == "")
            {
                MessageBox.Show("请输入数量");
                return;
            }

            int num;
            try
            {
                num = int.Parse(textnum.Text);
            }
            catch
            {
                MessageBox.Show("请输入正确数字");
                return;
            }
            

            //获取地址 
            string address = textaddress.Text;

            if (address == "")
            {
                MessageBox.Show("请输入地址");
                return;
            }

            //计算价格
            int price=0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string menucn_name = dt.Rows[i][0].ToString();
                menucn_name = menucn_name.Trim();
                if (menu_name == menucn_name)
                    price = num * int.Parse(dt.Rows[i][1].ToString());
            }

            //创建url
            string handlerurl =
                url + "TSPlaceOrder_Handler.ashx?uname=" + uname + "&user_name=" + user_name +
                "&menu_name=" + menu_name + "&num=" + num + "&address=" + address + "&price=" + price;

            string result = HttpHelper.Get(handlerurl);

            if (result == "true")
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("failed");
            }
        }
    }
}
