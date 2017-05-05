namespace Takeaway_system
{
    partial class TSMain_user
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vieworder = new System.Windows.Forms.Button();
            this.deleteorder = new System.Windows.Forms.Button();
            this.placeorder = new System.Windows.Forms.Button();
            this.tourdishes = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.butLogin = new System.Windows.Forms.Button();
            this.butChPwd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.vieworder);
            this.groupBox1.Controls.Add(this.deleteorder);
            this.groupBox1.Controls.Add(this.placeorder);
            this.groupBox1.Controls.Add(this.tourdishes);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 16F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(165, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 476);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户功能";
            // 
            // vieworder
            // 
            this.vieworder.BackColor = System.Drawing.Color.White;
            this.vieworder.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vieworder.ForeColor = System.Drawing.Color.DimGray;
            this.vieworder.Location = new System.Drawing.Point(327, 93);
            this.vieworder.Name = "vieworder";
            this.vieworder.Size = new System.Drawing.Size(124, 124);
            this.vieworder.TabIndex = 28;
            this.vieworder.Text = "查看订单";
            this.vieworder.UseVisualStyleBackColor = false;
            this.vieworder.Click += new System.EventHandler(this.vieworder_Click);
            // 
            // deleteorder
            // 
            this.deleteorder.BackColor = System.Drawing.Color.White;
            this.deleteorder.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteorder.ForeColor = System.Drawing.Color.DimGray;
            this.deleteorder.Location = new System.Drawing.Point(327, 277);
            this.deleteorder.Name = "deleteorder";
            this.deleteorder.Size = new System.Drawing.Size(124, 124);
            this.deleteorder.TabIndex = 27;
            this.deleteorder.Text = "删除订单";
            this.deleteorder.UseVisualStyleBackColor = false;
            this.deleteorder.Click += new System.EventHandler(this.deleteorder_Click);
            // 
            // placeorder
            // 
            this.placeorder.BackColor = System.Drawing.Color.White;
            this.placeorder.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.placeorder.ForeColor = System.Drawing.Color.DimGray;
            this.placeorder.Location = new System.Drawing.Point(116, 277);
            this.placeorder.Name = "placeorder";
            this.placeorder.Size = new System.Drawing.Size(124, 124);
            this.placeorder.TabIndex = 25;
            this.placeorder.Text = "提交订单";
            this.placeorder.UseVisualStyleBackColor = false;
            this.placeorder.Click += new System.EventHandler(this.placeorder_Click);
            // 
            // tourdishes
            // 
            this.tourdishes.BackColor = System.Drawing.Color.White;
            this.tourdishes.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tourdishes.ForeColor = System.Drawing.Color.DimGray;
            this.tourdishes.Location = new System.Drawing.Point(116, 93);
            this.tourdishes.Name = "tourdishes";
            this.tourdishes.Size = new System.Drawing.Size(124, 124);
            this.tourdishes.TabIndex = 24;
            this.tourdishes.Text = "游览商家";
            this.tourdishes.UseVisualStyleBackColor = false;
            this.tourdishes.Click += new System.EventHandler(this.tourdishes_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(-21, 453);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 12);
            this.labelUserName.TabIndex = 28;
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.White;
            this.butExit.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butExit.ForeColor = System.Drawing.Color.DimGray;
            this.butExit.Location = new System.Drawing.Point(21, 320);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(102, 93);
            this.butExit.TabIndex = 25;
            this.butExit.Text = "退出";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.White;
            this.butLogin.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butLogin.ForeColor = System.Drawing.Color.DimGray;
            this.butLogin.Location = new System.Drawing.Point(21, 74);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(102, 93);
            this.butLogin.TabIndex = 27;
            this.butLogin.Text = "重新登录";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butChPwd
            // 
            this.butChPwd.BackColor = System.Drawing.Color.White;
            this.butChPwd.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butChPwd.ForeColor = System.Drawing.Color.DimGray;
            this.butChPwd.Location = new System.Drawing.Point(21, 198);
            this.butChPwd.Name = "butChPwd";
            this.butChPwd.Size = new System.Drawing.Size(102, 93);
            this.butChPwd.TabIndex = 26;
            this.butChPwd.Text = "修改密码";
            this.butChPwd.UseVisualStyleBackColor = false;
            this.butChPwd.Click += new System.EventHandler(this.butChPwd_Click);
            // 
            // TSMain_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.butChPwd);
            this.Name = "TSMain_user";
            this.Text = "TSMain_user";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TSMain_user_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteorder;
        private System.Windows.Forms.Button placeorder;
        private System.Windows.Forms.Button tourdishes;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butChPwd;
        private System.Windows.Forms.Button vieworder;
    }
}