namespace Takeaway_system
{
    partial class TSRemoveOrder
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
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.uploadpicture = new System.Windows.Forms.Button();
            this.textid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.RowTemplate.Height = 23;
            this.dataGridViewOrder.Size = new System.Drawing.Size(840, 294);
            this.dataGridViewOrder.TabIndex = 1;
            // 
            // uploadpicture
            // 
            this.uploadpicture.BackColor = System.Drawing.Color.SkyBlue;
            this.uploadpicture.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.uploadpicture.ForeColor = System.Drawing.Color.White;
            this.uploadpicture.Location = new System.Drawing.Point(450, 314);
            this.uploadpicture.Name = "uploadpicture";
            this.uploadpicture.Size = new System.Drawing.Size(127, 36);
            this.uploadpicture.TabIndex = 30;
            this.uploadpicture.Text = "删除";
            this.uploadpicture.UseVisualStyleBackColor = false;
            this.uploadpicture.Click += new System.EventHandler(this.uploadpicture_Click);
            // 
            // textid
            // 
            this.textid.Font = new System.Drawing.Font("宋体", 13F);
            this.textid.Location = new System.Drawing.Point(260, 320);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(145, 27);
            this.textid.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(197, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "编号:";
            // 
            // TSRemoveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.uploadpicture);
            this.Controls.Add(this.dataGridViewOrder);
            this.Name = "TSRemoveOrder";
            this.Text = "TSRemoveOrder";
            this.Load += new System.EventHandler(this.TSRemoveOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button uploadpicture;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label1;


    }
}