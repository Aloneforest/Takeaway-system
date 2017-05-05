using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takeaway_system
{
    public partial class TSMain_business : Form
    {
        public string uname;
        public string id;

        public TSMain_business()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        //添加菜品
        private void adddishes_Click(object sender, EventArgs e)
        {
            TSAdddishes from = new TSAdddishes();
            from.uname = uname;
            from.Show();
        }

        //查看菜单
        private void viewmenu_Click(object sender, EventArgs e)
        {
            TSViewMenu from = new TSViewMenu();
            from.uname = uname;
            from.Show();
        }

        //修改菜品
        private void changedishes_Click(object sender, EventArgs e)
        {
            TSChangeDishes from = new TSChangeDishes();
            from.uname = uname;
            from.Show();
        }

        //删除菜品
        private void removedishes_Click(object sender, EventArgs e)
        {
            TSRemoveDishes from = new TSRemoveDishes();
            from.uname = uname;
            from.Show();
        }

        //修改密码
        private void butChPwd_Click(object sender, EventArgs e)
        {
            TSChangePwd from = new TSChangePwd();
            from.uname = uname;
            from.id = "2";
            from.Show();
        }

        //重新登陆
        private void butLogin_Click(object sender, EventArgs e)
        {
            TSLogin from = new TSLogin();
            from.Show();
            this.Visible = false;
        }

        //关闭窗口
        private void TSMain_business_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //退出窗口
        private void butExit_Click(object sender, EventArgs e)
        {
            TSMessage from = new TSMessage();
            from.Show();
        }

        //查看订单
        private void vieworder_Click(object sender, EventArgs e)
        {
            TSViewOrder from = new TSViewOrder();
            from.uname = uname;
            from.id = id;
            from.Show();
        }
    }
}
