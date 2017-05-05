namespace Takeaway_system
{
    partial class TSChangeDishes
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
            this.MenulistBox = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textprice = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.changprice = new System.Windows.Forms.Button();
            this.uploadpicture = new System.Windows.Forms.Button();
            this.confirmupload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenulistBox
            // 
            this.MenulistBox.Font = new System.Drawing.Font("宋体", 13F);
            this.MenulistBox.FormattingEnabled = true;
            this.MenulistBox.ItemHeight = 17;
            this.MenulistBox.Location = new System.Drawing.Point(43, 45);
            this.MenulistBox.Name = "MenulistBox";
            this.MenulistBox.Size = new System.Drawing.Size(115, 276);
            this.MenulistBox.TabIndex = 1;
            this.MenulistBox.Click += new System.EventHandler(this.ViweDish_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 13F);
            this.label.Location = new System.Drawing.Point(244, 45);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 18);
            this.label.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(179, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "价格：";
            // 
            // textprice
            // 
            this.textprice.Font = new System.Drawing.Font("宋体", 15F);
            this.textprice.Location = new System.Drawing.Point(337, 40);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(73, 30);
            this.textprice.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(182, 96);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(229, 225);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // changprice
            // 
            this.changprice.BackColor = System.Drawing.Color.SkyBlue;
            this.changprice.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.changprice.ForeColor = System.Drawing.Color.White;
            this.changprice.Location = new System.Drawing.Point(439, 36);
            this.changprice.Name = "changprice";
            this.changprice.Size = new System.Drawing.Size(75, 36);
            this.changprice.TabIndex = 20;
            this.changprice.Text = "价格修改";
            this.changprice.UseVisualStyleBackColor = false;
            this.changprice.Click += new System.EventHandler(this.changprice_Click);
            // 
            // uploadpicture
            // 
            this.uploadpicture.BackColor = System.Drawing.Color.SkyBlue;
            this.uploadpicture.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.uploadpicture.ForeColor = System.Drawing.Color.White;
            this.uploadpicture.Location = new System.Drawing.Point(440, 243);
            this.uploadpicture.Name = "uploadpicture";
            this.uploadpicture.Size = new System.Drawing.Size(74, 36);
            this.uploadpicture.TabIndex = 21;
            this.uploadpicture.Text = "上传图片";
            this.uploadpicture.UseVisualStyleBackColor = false;
            this.uploadpicture.Click += new System.EventHandler(this.uploadpicture_Click);
            // 
            // confirmupload
            // 
            this.confirmupload.BackColor = System.Drawing.Color.SkyBlue;
            this.confirmupload.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.confirmupload.ForeColor = System.Drawing.Color.White;
            this.confirmupload.Location = new System.Drawing.Point(440, 285);
            this.confirmupload.Name = "confirmupload";
            this.confirmupload.Size = new System.Drawing.Size(74, 36);
            this.confirmupload.TabIndex = 22;
            this.confirmupload.Text = "确定上传";
            this.confirmupload.UseVisualStyleBackColor = false;
            this.confirmupload.Click += new System.EventHandler(this.confirmupload_Click);
            // 
            // TSChangeDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 364);
            this.Controls.Add(this.confirmupload);
            this.Controls.Add(this.uploadpicture);
            this.Controls.Add(this.changprice);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenulistBox);
            this.Name = "TSChangeDishes";
            this.Text = "TSChangeDishes";
            this.Load += new System.EventHandler(this.TSChangeDishes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MenulistBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button changprice;
        private System.Windows.Forms.Button uploadpicture;
        private System.Windows.Forms.Button confirmupload;
    }
}