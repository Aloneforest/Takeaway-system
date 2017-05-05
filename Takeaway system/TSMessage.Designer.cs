namespace Takeaway_system
{
    partial class TSMessage
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
            this.groupMessage = new System.Windows.Forms.GroupBox();
            this.MessageCancel = new System.Windows.Forms.Button();
            this.MessageExit = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.groupMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMessage
            // 
            this.groupMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupMessage.Controls.Add(this.MessageCancel);
            this.groupMessage.Controls.Add(this.MessageExit);
            this.groupMessage.Controls.Add(this.Message);
            this.groupMessage.Font = new System.Drawing.Font("宋体", 12F);
            this.groupMessage.Location = new System.Drawing.Point(12, 12);
            this.groupMessage.Name = "groupMessage";
            this.groupMessage.Size = new System.Drawing.Size(248, 238);
            this.groupMessage.TabIndex = 1;
            this.groupMessage.TabStop = false;
            this.groupMessage.Text = "最后的确认";
            // 
            // MessageCancel
            // 
            this.MessageCancel.BackColor = System.Drawing.Color.SkyBlue;
            this.MessageCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MessageCancel.ForeColor = System.Drawing.Color.White;
            this.MessageCancel.Location = new System.Drawing.Point(134, 129);
            this.MessageCancel.Name = "MessageCancel";
            this.MessageCancel.Size = new System.Drawing.Size(94, 41);
            this.MessageCancel.TabIndex = 5;
            this.MessageCancel.Text = "并不退出";
            this.MessageCancel.UseVisualStyleBackColor = false;
            this.MessageCancel.Click += new System.EventHandler(this.MessageCancel_Click);
            // 
            // MessageExit
            // 
            this.MessageExit.BackColor = System.Drawing.Color.SkyBlue;
            this.MessageExit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MessageExit.ForeColor = System.Drawing.Color.White;
            this.MessageExit.Location = new System.Drawing.Point(21, 129);
            this.MessageExit.Name = "MessageExit";
            this.MessageExit.Size = new System.Drawing.Size(94, 41);
            this.MessageExit.TabIndex = 4;
            this.MessageExit.Text = "确认退出";
            this.MessageExit.UseVisualStyleBackColor = false;
            this.MessageExit.Click += new System.EventHandler(this.MessageExit_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Message.Location = new System.Drawing.Point(7, 63);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(234, 21);
            this.Message.TabIndex = 3;
            this.Message.Text = "确认已保存所有工作并退出吗？";
            // 
            // TSMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(271, 260);
            this.Controls.Add(this.groupMessage);
            this.Name = "TSMessage";
            this.Text = "TSMessage";
            this.groupMessage.ResumeLayout(false);
            this.groupMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMessage;
        private System.Windows.Forms.Button MessageCancel;
        private System.Windows.Forms.Button MessageExit;
        private System.Windows.Forms.Label Message;
    }
}