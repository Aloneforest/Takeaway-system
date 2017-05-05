namespace Takeaway_system
{
    partial class TSAddOrder
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
            this.BusinesslistBox = new System.Windows.Forms.ListBox();
            this.MenulistBox = new System.Windows.Forms.ListBox();
            this.textnum = new System.Windows.Forms.TextBox();
            this.addpicture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BusinesslistBox
            // 
            this.BusinesslistBox.Font = new System.Drawing.Font("宋体", 13F);
            this.BusinesslistBox.FormattingEnabled = true;
            this.BusinesslistBox.ItemHeight = 17;
            this.BusinesslistBox.Location = new System.Drawing.Point(64, 37);
            this.BusinesslistBox.Name = "BusinesslistBox";
            this.BusinesslistBox.Size = new System.Drawing.Size(115, 276);
            this.BusinesslistBox.TabIndex = 2;
            this.BusinesslistBox.Click += new System.EventHandler(this.ViweBusress_Click);
            // 
            // MenulistBox
            // 
            this.MenulistBox.Font = new System.Drawing.Font("宋体", 13F);
            this.MenulistBox.FormattingEnabled = true;
            this.MenulistBox.ItemHeight = 17;
            this.MenulistBox.Location = new System.Drawing.Point(249, 37);
            this.MenulistBox.Name = "MenulistBox";
            this.MenulistBox.Size = new System.Drawing.Size(115, 276);
            this.MenulistBox.TabIndex = 3;
            // 
            // textnum
            // 
            this.textnum.Font = new System.Drawing.Font("宋体", 12F);
            this.textnum.Location = new System.Drawing.Point(163, 345);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(182, 26);
            this.textnum.TabIndex = 4;
            // 
            // addpicture
            // 
            this.addpicture.BackColor = System.Drawing.Color.SkyBlue;
            this.addpicture.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.addpicture.ForeColor = System.Drawing.Color.White;
            this.addpicture.Location = new System.Drawing.Point(87, 447);
            this.addpicture.Name = "addpicture";
            this.addpicture.Size = new System.Drawing.Size(257, 38);
            this.addpicture.TabIndex = 22;
            this.addpicture.Text = "添加订单";
            this.addpicture.UseVisualStyleBackColor = false;
            this.addpicture.Click += new System.EventHandler(this.addpicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(84, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "数量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(84, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "地址:";
            // 
            // textaddress
            // 
            this.textaddress.Font = new System.Drawing.Font("宋体", 12F);
            this.textaddress.Location = new System.Drawing.Point(163, 390);
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(181, 26);
            this.textaddress.TabIndex = 24;
            // 
            // TSAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textaddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addpicture);
            this.Controls.Add(this.textnum);
            this.Controls.Add(this.MenulistBox);
            this.Controls.Add(this.BusinesslistBox);
            this.Name = "TSAddOrder";
            this.Text = "TSPlaceOrder";
            this.Load += new System.EventHandler(this.TSPlaceOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BusinesslistBox;
        private System.Windows.Forms.ListBox MenulistBox;
        private System.Windows.Forms.TextBox textnum;
        private System.Windows.Forms.Button addpicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textaddress;
    }
}