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
            if (BusinesslistBox.SelectedIndex < 0)
                return;

            //获取商家名
            string name = BusinesslistBox.Items[BusinesslistBox.SelectedIndex].ToString();
            name = name.Trim();

            TSViewMenu from = new TSViewMenu();
            from.uname = name;
            from.Show();
        }
    }
}
