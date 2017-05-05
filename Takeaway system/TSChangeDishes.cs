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
    public partial class TSChangeDishes : Form
    {
        public string uname="he";

        //设置连接到配置文件组建 App.config,获得连接地址
        string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;

        //图片地址
        string filePath;

        ViewMenu_Load f = new ViewMenu_Load();

        public TSChangeDishes()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void TSChangeDishes_Load(object sender, EventArgs e)
        {
            f.uname = uname;
            f.TSViewMenu_Load(MenulistBox);
        }

        private void ViweDish_Click(object sender, EventArgs e)
        {
            f.TSViweDish_Click(MenulistBox, label, pictureBox);
        }

        private void changprice_Click(object sender, EventArgs e)
        {
            string chprice = textprice.Text;

            if (pictureBox.Image == null)
            {
                MessageBox.Show("请先选择菜品");
                return;
            }

            //获取菜品名
            string name = MenulistBox.Items[MenulistBox.SelectedIndex].ToString();
            name = name.Trim();

            //判断价格是否为空
            if (chprice.Trim() == "")
            {
                MessageBox.Show("价格不能为空!");
                return;
            }

            //创建url
            string handlerurl =
                url + "TSChangeDishes_chpr_Handler.ashx?chprice=" + chprice + "&name=" + name;

            //访问服务器
            string result = HttpHelper.Get(handlerurl);

            //判断更改是否成功
            if (result == "true")
                MessageBox.Show("success");
            else
                MessageBox.Show("err");

        }

        private void uploadpicture_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("请先选择菜品");
                return;
            }

            //选择上传文件
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*jpg|*.JPG|*.GIF|*.GIF|*.BMP|*.BMP";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //图片路径
                filePath = ofd.FileName;
                //fileName = Path.GetFileName(filePath);

                //预览图片
                pictureBox.Image = Image.FromFile(filePath);
            }
        }

        private void confirmupload_Click(object sender, EventArgs e)
        {
            if (filePath == null)
            {
                MessageBox.Show("请先上传图片");
                return;
            }

            if (pictureBox.Image == null)
            {
                MessageBox.Show("请先选择菜品");
                return;
            }

            //获取菜品名
            string name = MenulistBox.Items[MenulistBox.SelectedIndex].ToString();
            name = name.Trim();

            //创建url
            string handlerurl =
                url + "TSChangeDishes_chpi_Handler.ashx?fileName=" + name + ".jpg";

            //string result = HttpHelper.Get(handlerurl);

            //上传图片
            WebClient myWebClient = new WebClient();
            string flag = Encoding.Default.GetString(myWebClient.UploadFile(handlerurl, "POST", filePath));//获取返回值


            if (flag == "true")
            {
                MessageBox.Show("success");
                pictureBox.Image = null;
                filePath = null;
                //File.Delete(Application.StartupPath + "\\" + name + ".jpg");
            }
            else
            {
                MessageBox.Show("failed");
            }
        }
    }
}
