namespace Takeaway_system
{
    partial class TSRemoveDishes
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
            this.uploadpicture = new System.Windows.Forms.Button();
            this.MenulistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uploadpicture
            // 
            this.uploadpicture.BackColor = System.Drawing.Color.SkyBlue;
            this.uploadpicture.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.uploadpicture.ForeColor = System.Drawing.Color.White;
            this.uploadpicture.Location = new System.Drawing.Point(12, 294);
            this.uploadpicture.Name = "uploadpicture";
            this.uploadpicture.Size = new System.Drawing.Size(127, 36);
            this.uploadpicture.TabIndex = 29;
            this.uploadpicture.Text = "删除";
            this.uploadpicture.UseVisualStyleBackColor = false;
            this.uploadpicture.Click += new System.EventHandler(this.uploadpicture_Click);
            // 
            // MenulistBox
            // 
            this.MenulistBox.Font = new System.Drawing.Font("宋体", 13F);
            this.MenulistBox.FormattingEnabled = true;
            this.MenulistBox.ItemHeight = 17;
            this.MenulistBox.Location = new System.Drawing.Point(12, 12);
            this.MenulistBox.Name = "MenulistBox";
            this.MenulistBox.Size = new System.Drawing.Size(127, 276);
            this.MenulistBox.TabIndex = 23;
            // 
            // TSRemoveDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 340);
            this.Controls.Add(this.uploadpicture);
            this.Controls.Add(this.MenulistBox);
            this.Name = "TSRemoveDishes";
            this.Text = "TSRemoveDishes";
            this.Load += new System.EventHandler(this.TSRemoveDishes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadpicture;
        private System.Windows.Forms.ListBox MenulistBox;

    }
}