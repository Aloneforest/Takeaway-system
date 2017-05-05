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
    public partial class TSMain_user : Form
    {
        public string uname;
        public string id;

        public TSMain_user()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        //修改密码
        private void butChPwd_Click(object sender, EventArgs e)
        {
            TSChangePwd from = new TSChangePwd();
            from.uname = uname;
            from.id = "1";
            from.Show();
        }

        //游览商家
        private void tourdishes_Click(object sender, EventArgs e)
        {
            TSViewBusress from = new TSViewBusress();
            from.uname = uname;
            from.Show();
        }

        //重新登录
        private void butLogin_Click(object sender, EventArgs e)
        {
            TSLogin from = new TSLogin();
            from.Show();
            this.Visible = false;
        }

        //提交菜单
        private void placeorder_Click(object sender, EventArgs e)
        {
            TSAddOrder from = new TSAddOrder();
            from.uname = uname;
            from.Show();
        }

        //查看菜单
        private void vieworder_Click(object sender, EventArgs e)
        {
            TSViewOrder from = new TSViewOrder();
            from.uname = uname;
            from.id = id;
            from.Show();
        }

        //关闭窗口
        private void TSMain_user_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //退出窗口
        private void butExit_Click(object sender, EventArgs e)
        {
            TSMessage from = new TSMessage();
            from.Show();
        }

        //删除订单
        private void deleteorder_Click(object sender, EventArgs e)
        {
            TSRemoveOrder from = new TSRemoveOrder();
            from.uname = uname;
            from.Show();
        }
    }
}
