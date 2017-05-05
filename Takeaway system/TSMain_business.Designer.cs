namespace Takeaway_system
{
    partial class TSMain_business
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserName = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.butLogin = new System.Windows.Forms.Button();
            this.butChPwd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewmenu = new System.Windows.Forms.Button();
            this.vieworder = new System.Windows.Forms.Button();
            this.removedishes = new System.Windows.Forms.Button();
            this.changedishes = new System.Windows.Forms.Button();
            this.adddishes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(-19, 453);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 12);
            this.labelUserName.TabIndex = 22;
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.White;
            this.butExit.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butExit.ForeColor = System.Drawing.Color.DimGray;
            this.butExit.Location = new System.Drawing.Point(12, 317);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(102, 93);
            this.butExit.TabIndex = 19;
            this.butExit.Text = "退出";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.White;
            this.butLogin.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butLogin.ForeColor = System.Drawing.Color.DimGray;
            this.butLogin.Location = new System.Drawing.Point(12, 75);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(102, 93);
            this.butLogin.TabIndex = 21;
            this.butLogin.Text = "重新登录";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butChPwd
            // 
            this.butChPwd.BackColor = System.Drawing.Color.White;
            this.butChPwd.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butChPwd.ForeColor = System.Drawing.Color.DimGray;
            this.butChPwd.Location = new System.Drawing.Point(12, 197);
            this.butChPwd.Name = "butChPwd";
            this.butChPwd.Size = new System.Drawing.Size(102, 93);
            this.butChPwd.TabIndex = 20;
            this.butChPwd.Text = "修改密码";
            this.butChPwd.UseVisualStyleBackColor = false;
            this.butChPwd.Click += new System.EventHandler(this.butChPwd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.viewmenu);
            this.groupBox1.Controls.Add(this.vieworder);
            this.groupBox1.Controls.Add(this.removedishes);
            this.groupBox1.Controls.Add(this.changedishes);
            this.groupBox1.Controls.Add(this.adddishes);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 16F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(167, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 476);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商家功能";
            // 
            // viewmenu
            // 
            this.viewmenu.BackColor = System.Drawing.Color.White;
            this.viewmenu.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.viewmenu.ForeColor = System.Drawing.Color.DimGray;
            this.viewmenu.Location = new System.Drawing.Point(78, 88);
            this.viewmenu.Name = "viewmenu";
            this.viewmenu.Size = new System.Drawing.Size(214, 60);
            this.viewmenu.TabIndex = 28;
            this.viewmenu.Text = "查看菜单";
            this.viewmenu.UseVisualStyleBackColor = false;
            this.viewmenu.Click += new System.EventHandler(this.viewmenu_Click);
            // 
            // vieworder
            // 
            this.vieworder.BackColor = System.Drawing.Color.White;
            this.vieworder.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vieworder.ForeColor = System.Drawing.Color.DimGray;
            this.vieworder.Location = new System.Drawing.Point(317, 172);
            this.vieworder.Name = "vieworder";
            this.vieworder.Size = new System.Drawing.Size(209, 143);
            this.vieworder.TabIndex = 27;
            this.vieworder.Text = "查看订单";
            this.vieworder.UseVisualStyleBackColor = false;
            this.vieworder.Click += new System.EventHandler(this.vieworder_Click);
            // 
            // removedishes
            // 
            this.removedishes.BackColor = System.Drawing.Color.White;
            this.removedishes.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.removedishes.ForeColor = System.Drawing.Color.DimGray;
            this.removedishes.Location = new System.Drawing.Point(78, 338);
            this.removedishes.Name = "removedishes";
            this.removedishes.Size = new System.Drawing.Size(214, 60);
            this.removedishes.TabIndex = 26;
            this.removedishes.Text = "删除菜品";
            this.removedishes.UseVisualStyleBackColor = false;
            this.removedishes.Click += new System.EventHandler(this.removedishes_Click);
            // 
            // changedishes
            // 
            this.changedishes.BackColor = System.Drawing.Color.White;
            this.changedishes.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changedishes.ForeColor = System.Drawing.Color.DimGray;
            this.changedishes.Location = new System.Drawing.Point(78, 255);
            this.changedishes.Name = "changedishes";
            this.changedishes.Size = new System.Drawing.Size(214, 60);
            this.changedishes.TabIndex = 25;
            this.changedishes.Text = "更改菜品";
            this.changedishes.UseVisualStyleBackColor = false;
            this.changedishes.Click += new System.EventHandler(this.changedishes_Click);
            // 
            // adddishes
            // 
            this.adddishes.BackColor = System.Drawing.Color.White;
            this.adddishes.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adddishes.ForeColor = System.Drawing.Color.DimGray;
            this.adddishes.Location = new System.Drawing.Point(78, 172);
            this.adddishes.Name = "adddishes";
            this.adddishes.Size = new System.Drawing.Size(214, 60);
            this.adddishes.TabIndex = 24;
            this.adddishes.Text = "添加菜品";
            this.adddishes.UseVisualStyleBackColor = false;
            this.adddishes.Click += new System.EventHandler(this.adddishes_Click);
            // 
            // TSMain_business
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.butChPwd);
            this.Name = "TSMain_business";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TSMain_business_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butChPwd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button vieworder;
        private System.Windows.Forms.Button removedishes;
        private System.Windows.Forms.Button changedishes;
        private System.Windows.Forms.Button adddishes;
        private System.Windows.Forms.Button viewmenu;
    }
}