namespace Takeaway_system
{
    partial class TSViewBusress
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
            this.SuspendLayout();
            // 
            // BusinesslistBox
            // 
            this.BusinesslistBox.Font = new System.Drawing.Font("宋体", 13F);
            this.BusinesslistBox.FormattingEnabled = true;
            this.BusinesslistBox.ItemHeight = 17;
            this.BusinesslistBox.Location = new System.Drawing.Point(12, 12);
            this.BusinesslistBox.Name = "BusinesslistBox";
            this.BusinesslistBox.Size = new System.Drawing.Size(163, 480);
            this.BusinesslistBox.TabIndex = 24;
            this.BusinesslistBox.Click += new System.EventHandler(this.ViweBusress_Click);
            // 
            // TSViewBusress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 516);
            this.Controls.Add(this.BusinesslistBox);
            this.Name = "TSViewBusress";
            this.Text = "TSViewBusress";
            this.Load += new System.EventHandler(this.TSViewBusress_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BusinesslistBox;
    }
}