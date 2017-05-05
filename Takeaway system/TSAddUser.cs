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
    public partial class TSAddUser : Form
    {
        //设置连接到配置文件组建 App.config,获得连接地址
        string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;

        public TSAddUser()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            //获取参数
            string uname = txtUserName.Text;
            string pwd = txtPassWord.Text;
            string pwdc = txtPwdConfirm.Text;
            int id;
            if (radiouser.Checked == true)
                id = 1;
            else
                id = 2;

            //如果用户名不存在 则判断下用户名密码是否为空
            if (uname.Trim() == "")
            {
                MessageBox.Show("用户名不能为空!");
                return;
            }

            //判断密码是否为空
            if (pwd.Trim() == "")
            {
                MessageBox.Show("密码不能为空!");
                return;
            }

            //判断再次输入密码是否为空
            if (pwdc.Trim() == "")
            {
                MessageBox.Show("密码确认不能为空!");
                return;
            }

            //判断2次密码输入是否相同
            if (pwd != pwdc)
            {
                MessageBox.Show("两次密码不同");
                txtPassWord.Text = "";
                txtPwdConfirm.Text = "";
                return;
            }

            //创建url
            string handlerurl =
                url + "TSAddUser_Handler.ashx?id=" + id + "&uname=" + uname + "&pwd=" + pwd;

            //访问服务器
            string result = HttpHelper.Get(handlerurl);

            //判断用户名和密码是否匹配
            if (result == "true")
                MessageBox.Show("success");
            else 
                MessageBox.Show("err");
        }
    }
}
