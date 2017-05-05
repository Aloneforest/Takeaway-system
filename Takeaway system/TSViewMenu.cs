using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class TSViewMenu : Form
    {
        public string uname;

        //设置连接到配置文件组建 App.config,获得连接地址
        string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;

        //菜品表
        DataTable dt;

        ViewMenu_Load f = new ViewMenu_Load();

        public TSViewMenu()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void TSViewMenu_Load(object sender, EventArgs e)
        {
            f.uname = uname;
            f.TSViewMenu_Load(MenulistBox);
        }

        private void ViweDish_Click(object sender, EventArgs e)
        {
            f.TSViweDish_Click(MenulistBox, label, pictureBox);
        }
    }
}
