namespace Takeaway_system
{
    partial class TSLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.butAddUser = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPassWord = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.butLogin = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.radiouser = new System.Windows.Forms.RadioButton();
            this.radiobusiness = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(424, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "没有账号？";
            // 
            // butAddUser
            // 
            this.butAddUser.BackColor = System.Drawing.Color.White;
            this.butAddUser.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butAddUser.ForeColor = System.Drawing.Color.Gray;
            this.butAddUser.Location = new System.Drawing.Point(520, 414);
            this.butAddUser.Name = "butAddUser";
            this.butAddUser.Size = new System.Drawing.Size(100, 38);
            this.butAddUser.TabIndex = 22;
            this.butAddUser.Text = "立即注册";
            this.butAddUser.UseVisualStyleBackColor = false;
            this.butAddUser.Click += new System.EventHandler(this.butAddUser_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.No;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelTitle.Location = new System.Drawing.Point(173, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(256, 75);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "外卖系统";
            // 
            // labelPassWord
            // 
            this.labelPassWord.AutoSize = true;
            this.labelPassWord.Font = new System.Drawing.Font("宋体", 15F);
            this.labelPassWord.Location = new System.Drawing.Point(145, 219);
            this.labelPassWord.Name = "labelPassWord";
            this.labelPassWord.Size = new System.Drawing.Size(99, 20);
            this.labelPassWord.TabIndex = 20;
            this.labelPassWord.Text = "密   码：";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("宋体", 15F);
            this.labelUser.Location = new System.Drawing.Point(143, 159);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(89, 20);
            this.labelUser.TabIndex = 19;
            this.labelUser.Text = "用户名：";
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.butLogin.Font = new System.Drawing.Font("宋体", 15F);
            this.butLogin.ForeColor = System.Drawing.Color.White;
            this.butLogin.Location = new System.Drawing.Point(128, 319);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(126, 62);
            this.butLogin.TabIndex = 18;
            this.butLogin.Text = "登陆";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("宋体", 15F);
            this.txtPassWord.Location = new System.Drawing.Point(253, 216);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(198, 30);
            this.txtPassWord.TabIndex = 17;
            this.txtPassWord.Text = "123";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("宋体", 15F);
            this.txtUser.Location = new System.Drawing.Point(253, 156);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(198, 30);
            this.txtUser.TabIndex = 16;
            this.txtUser.Text = "he";
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.butCancel.Font = new System.Drawing.Font("宋体", 15F);
            this.butCancel.ForeColor = System.Drawing.Color.White;
            this.butCancel.Location = new System.Drawing.Point(342, 319);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(126, 62);
            this.butCancel.TabIndex = 15;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // radiouser
            // 
            this.radiouser.AutoSize = true;
            this.radiouser.Checked = true;
            this.radiouser.Font = new System.Drawing.Font("宋体", 12F);
            this.radiouser.Location = new System.Drawing.Point(191, 277);
            this.radiouser.Name = "radiouser";
            this.radiouser.Size = new System.Drawing.Size(58, 20);
            this.radiouser.TabIndex = 24;
            this.radiouser.TabStop = true;
            this.radiouser.Text = "用户";
            this.radiouser.UseVisualStyleBackColor = true;
            // 
            // radiobusiness
            // 
            this.radiobusiness.AutoSize = true;
            this.radiobusiness.Font = new System.Drawing.Font("宋体", 12F);
            this.radiobusiness.Location = new System.Drawing.Point(371, 277);
            this.radiobusiness.Name = "radiobusiness";
            this.radiobusiness.Size = new System.Drawing.Size(58, 20);
            this.radiobusiness.TabIndex = 25;
            this.radiobusiness.Text = "商家";
            this.radiobusiness.UseVisualStyleBackColor = true;
            // 
            // TSLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(632, 470);
            this.Controls.Add(this.radiobusiness);
            this.Controls.Add(this.radiouser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butAddUser);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelPassWord);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.butCancel);
            this.Name = "TSLogin";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TSLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butAddUser;
        private System.Windows.Forms.Label labelPassWord;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton radiouser;
        private System.Windows.Forms.RadioButton radiobusiness;

    }
}

