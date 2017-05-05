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
    public partial class TSChangePwd : Form
    {
        //设置连接到配置文件组建 App.config,获得连接地址
        string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;

        public string id;
        public string uname;

        public TSChangePwd()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void butChPwdOK_Click(object sender, EventArgs e)
        {
            //获取用户名、密码和身份
            string oldpwd = txtOldPassWord.Text;
            string newpwd = txtNewPassWord.Text;
            string newpwda = txtNewPassWordAgain.Text;

            if(newpwd != newpwda)
            {
                MessageBox.Show("两次密码不一样");
                return;
            }

            //创建url
            string handlerurl =
                url + "TSLogin_Handler.ashx?id=" + id + "&uname=" + uname + "&pwd=" + oldpwd;

            //访问服务器
            string result = HttpHelper.Get(handlerurl);

            //判断用户名和密码是否匹配
            if (result == "true")
            {
                handlerurl =
                    url + "TSChangePwd_Handler.ashx?id=" + id + "&uname=" + uname + "&pow=" + newpwd;

                //访问服务器
                result = HttpHelper.Get(handlerurl);

                //判断更改是否成功
                if (result == "true")
                    MessageBox.Show("success");
                else
                    MessageBox.Show("err");

            }
            else MessageBox.Show("密码错误");
        }
    }
}
