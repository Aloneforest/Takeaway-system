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
    public partial class TSViewOrder : Form
    {
        public string uname;
        public string id;

        //设置连接到配置文件组建 App.config,获得连接地址
        string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;

        //订单表
        DataTable dt;

        public TSViewOrder()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void TSViewOrder_Load(object sender, EventArgs e)
        {
            string handlerurl =
                url + "TSViewOrder_Handler.ashx?uname=" + uname + "&id=" + id;

            //访问服务器
            string json = HttpHelper.Get(handlerurl);

            if (json == "")
                return;

            dt = Common.JsonHelper.JsonToDataTable(json);

            dataGridViewOrder.DataSource = dt;
        }
    }
}
