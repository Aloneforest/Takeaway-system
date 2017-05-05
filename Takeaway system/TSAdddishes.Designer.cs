namespace Takeaway_system
{
    partial class TSAdddishes
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.addpicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(159, 98);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '*';
            this.txtPrice.Size = new System.Drawing.Size(172, 21);
            this.txtPrice.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F);
            this.label2.Location = new System.Drawing.Point(55, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "价    格：";
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(159, 38);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(172, 21);
            this.txtDishName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "菜 品 名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F);
            this.label3.Location = new System.Drawing.Point(55, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "菜品图片：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(58, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.butCancel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butCancel.ForeColor = System.Drawing.Color.White;
            this.butCancel.Location = new System.Drawing.Point(238, 420);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(93, 45);
            this.butCancel.TabIndex = 20;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = false;
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.butAdd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.Location = new System.Drawing.Point(59, 420);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(93, 45);
            this.butAdd.TabIndex = 19;
            this.butAdd.Text = "确认";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // addpicture
            // 
            this.addpicture.BackColor = System.Drawing.Color.SkyBlue;
            this.addpicture.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.addpicture.ForeColor = System.Drawing.Color.White;
            this.addpicture.Location = new System.Drawing.Point(238, 146);
            this.addpicture.Name = "addpicture";
            this.addpicture.Size = new System.Drawing.Size(93, 38);
            this.addpicture.TabIndex = 21;
            this.addpicture.Text = "添加图片";
            this.addpicture.UseVisualStyleBackColor = false;
            this.addpicture.Click += new System.EventHandler(this.addpicture_Click);
            // 
            // TSAdddishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 496);
            this.Controls.Add(this.addpicture);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDishName);
            this.Controls.Add(this.label1);
            this.Name = "TSAdddishes";
            this.Text = "TSadddishes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button addpicture;
    }
}