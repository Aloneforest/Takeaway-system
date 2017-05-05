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
    public partial class TSLogin : Form
    {
        //string url = "http://119.29.250.249/";
        //string url = "http://localhost:55927/";

        //设置连接到配置文件组建 App.config,获得连接地址
        string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;

        public TSLogin()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            //获取用户名、密码和身份
            string uname = txtUser.Text;
            string pwd = txtPassWord.Text;
            int id;
            if (radiouser.Checked == true)
                id = 1;
            else
                id = 2;

            //创建url
            string handlerurl =
                url + "TSLogin_Handler.ashx?id=" + id + "&uname=" + uname + "&pwd=" + pwd;

            //访问服务器
            string result = HttpHelper.Get(handlerurl);

            //判断用户名和密码是否匹配
            if (result == "true")
            {
                if(id==1)
                {
                    TSMain_user form = new TSMain_user();
                    form.uname = txtUser.Text;
                    form.id = "1";
                    form.Show();
                    this.Visible = false;
                }
                else
                {
                    TSMain_business form = new TSMain_business();
                    form.uname = txtUser.Text;
                    form.id = "2";
                    form.Show();
                    this.Visible = false;
                }
            }
            else MessageBox.Show("err");
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            //退出程序
            Application.Exit();
        }

        private void butAddUser_Click(object sender, EventArgs e)
        {
            //new一个 添加用户窗体对象
            TSAddUser AddUser = new TSAddUser();
            //显示 添加用户窗体
            AddUser.Show();
            //隐藏当前窗体(主界面)
            //this.Hide();
        }

        private void TSLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //退出程序
            Application.Exit();
        }
    }
}
