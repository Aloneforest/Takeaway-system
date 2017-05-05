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
    public partial class TSAdddishes : Form
    {
        //设置连接到配置文件组建 App.config,获得连接地址
        string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;

        //图片地址
        string filePath;

        //商家名
        public string uname;

        public TSAdddishes()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void addpicture_Click(object sender, EventArgs e)
        {
            //选择上传文件
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*jpg|*.JPG|*.GIF|*.GIF|*.BMP|*.BMP";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //图片路径
                filePath = ofd.FileName;

                //预览图片
                pictureBox1.Image = Image.FromFile(filePath);
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            //获取参数
            string DishName = txtDishName.Text;
            string Price = txtPrice.Text;

            //创建url
            string handlerurl =
                url + "TSAdddishes_Handler.ashx?DishName=" + DishName + "&Price=" + Price + "&fileName=" + DishName + ".jpg" + "&uname=" + uname;

            //string result = HttpHelper.Get(handlerurl);

            //上传图片
            WebClient myWebClient = new WebClient();
            string flag = Encoding.Default.GetString(myWebClient.UploadFile(handlerurl, "POST", filePath));//获取返回值


            if (flag == "true")
            {
                MessageBox.Show("success");
                txtDishName.Text = null;
                txtPrice.Text = null;
                pictureBox1.Image = null;
                filePath = null;
            }
            else
            {
                MessageBox.Show("failed");
            }
        }
    }
}
