namespace Takeaway_system
{
    partial class TSChangePwd
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
            this.txtNewPassWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butChPwdCancel = new System.Windows.Forms.Button();
            this.txtOldPassWord = new System.Windows.Forms.TextBox();
            this.txtNewPassWordAgain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butChPwdOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewPassWord
            // 
            this.txtNewPassWord.Location = new System.Drawing.Point(174, 98);
            this.txtNewPassWord.Name = "txtNewPassWord";
            this.txtNewPassWord.PasswordChar = '*';
            this.txtNewPassWord.Size = new System.Drawing.Size(172, 21);
            this.txtNewPassWord.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13F);
            this.label4.Location = new System.Drawing.Point(62, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "新 密 码：";
            // 
            // butChPwdCancel
            // 
            this.butChPwdCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.butChPwdCancel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butChPwdCancel.ForeColor = System.Drawing.Color.White;
            this.butChPwdCancel.Location = new System.Drawing.Point(236, 222);
            this.butChPwdCancel.Name = "butChPwdCancel";
            this.butChPwdCancel.Size = new System.Drawing.Size(93, 45);
            this.butChPwdCancel.TabIndex = 23;
            this.butChPwdCancel.Text = "取消";
            this.butChPwdCancel.UseVisualStyleBackColor = false;
            // 
            // txtOldPassWord
            // 
            this.txtOldPassWord.Location = new System.Drawing.Point(174, 44);
            this.txtOldPassWord.Name = "txtOldPassWord";
            this.txtOldPassWord.PasswordChar = '*';
            this.txtOldPassWord.Size = new System.Drawing.Size(172, 21);
            this.txtOldPassWord.TabIndex = 18;
            // 
            // txtNewPassWordAgain
            // 
            this.txtNewPassWordAgain.Location = new System.Drawing.Point(174, 154);
            this.txtNewPassWordAgain.Name = "txtNewPassWordAgain";
            this.txtNewPassWordAgain.PasswordChar = '*';
            this.txtNewPassWordAgain.Size = new System.Drawing.Size(172, 21);
            this.txtNewPassWordAgain.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F);
            this.label3.Location = new System.Drawing.Point(62, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "确认密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F);
            this.label2.Location = new System.Drawing.Point(62, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "原 密 码：";
            // 
            // butChPwdOK
            // 
            this.butChPwdOK.BackColor = System.Drawing.Color.SkyBlue;
            this.butChPwdOK.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butChPwdOK.ForeColor = System.Drawing.Color.White;
            this.butChPwdOK.Location = new System.Drawing.Point(78, 222);
            this.butChPwdOK.Name = "butChPwdOK";
            this.butChPwdOK.Size = new System.Drawing.Size(93, 45);
            this.butChPwdOK.TabIndex = 22;
            this.butChPwdOK.Text = "确认";
            this.butChPwdOK.UseVisualStyleBackColor = false;
            this.butChPwdOK.Click += new System.EventHandler(this.butChPwdOK_Click);
            // 
            // TSChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(410, 300);
            this.Controls.Add(this.txtNewPassWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butChPwdCancel);
            this.Controls.Add(this.txtOldPassWord);
            this.Controls.Add(this.txtNewPassWordAgain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butChPwdOK);
            this.Name = "TSChangePwd";
            this.Text = "TSChPwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butChPwdCancel;
        private System.Windows.Forms.TextBox txtOldPassWord;
        private System.Windows.Forms.TextBox txtNewPassWordAgain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butChPwdOK;
    }
}