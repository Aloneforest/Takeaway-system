namespace Takeaway_system
{
    partial class TSAddUser
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
            this.butCancel = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtPwdConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radiouser = new System.Windows.Forms.RadioButton();
            this.radiobusiness = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.butCancel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butCancel.ForeColor = System.Drawing.Color.White;
            this.butCancel.Location = new System.Drawing.Point(222, 289);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(93, 45);
            this.butCancel.TabIndex = 13;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(158, 127);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(172, 21);
            this.txtPassWord.TabIndex = 8;
            // 
            // txtPwdConfirm
            // 
            this.txtPwdConfirm.Location = new System.Drawing.Point(158, 189);
            this.txtPwdConfirm.Name = "txtPwdConfirm";
            this.txtPwdConfirm.PasswordChar = '*';
            this.txtPwdConfirm.Size = new System.Drawing.Size(172, 21);
            this.txtPwdConfirm.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F);
            this.label3.Location = new System.Drawing.Point(54, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "确认密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F);
            this.label2.Location = new System.Drawing.Point(54, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "密    码：";
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.butAdd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.Location = new System.Drawing.Point(64, 289);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(93, 45);
            this.butAdd.TabIndex = 12;
            this.butAdd.Text = "确认";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(158, 67);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(172, 21);
            this.txtUserName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(54, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "用 户 名：";
            // 
            // radiouser
            // 
            this.radiouser.AutoSize = true;
            this.radiouser.Checked = true;
            this.radiouser.Font = new System.Drawing.Font("宋体", 11F);
            this.radiouser.Location = new System.Drawing.Point(102, 241);
            this.radiouser.Name = "radiouser";
            this.radiouser.Size = new System.Drawing.Size(55, 19);
            this.radiouser.TabIndex = 14;
            this.radiouser.TabStop = true;
            this.radiouser.Text = "用户";
            this.radiouser.UseVisualStyleBackColor = true;
            // 
            // radiobusiness
            // 
            this.radiobusiness.AutoSize = true;
            this.radiobusiness.Font = new System.Drawing.Font("宋体", 11F);
            this.radiobusiness.Location = new System.Drawing.Point(222, 241);
            this.radiobusiness.Name = "radiobusiness";
            this.radiobusiness.Size = new System.Drawing.Size(55, 19);
            this.radiobusiness.TabIndex = 15;
            this.radiobusiness.Text = "商家";
            this.radiobusiness.UseVisualStyleBackColor = true;
            // 
            // TSAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(381, 356);
            this.Controls.Add(this.radiobusiness);
            this.Controls.Add(this.radiouser);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtPwdConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Name = "TSAddUser";
            this.Text = "frmAddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtPwdConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radiouser;
        private System.Windows.Forms.RadioButton radiobusiness;

    }
}