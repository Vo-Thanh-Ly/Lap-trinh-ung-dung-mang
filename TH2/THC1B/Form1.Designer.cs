namespace THC1B
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.lstReceived = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSent = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.txtRemoteHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tin nhắn  gửi đi";
            // 
            // lstReceived
            // 
            this.lstReceived.FormattingEnabled = true;
            this.lstReceived.Location = new System.Drawing.Point(45, 218);
            this.lstReceived.Name = "lstReceived";
            this.lstReceived.Size = new System.Drawing.Size(387, 147);
            this.lstReceived.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tin nhắn gửi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dữ liệu nhận về từ náy chủ";
            // 
            // lstSent
            // 
            this.lstSent.FormattingEnabled = true;
            this.lstSent.Location = new System.Drawing.Point(45, 27);
            this.lstSent.Name = "lstSent";
            this.lstSent.Size = new System.Drawing.Size(387, 160);
            this.lstSent.TabIndex = 15;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(395, 407);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(37, 23);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(45, 407);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(344, 20);
            this.txtMsg.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtRemotePort);
            this.groupBox1.Controls.Add(this.txtRemoteHost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(438, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 181);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông số máy nhận";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(129, 127);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(129, 78);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(135, 20);
            this.txtRemotePort.TabIndex = 9;
            // 
            // txtRemoteHost
            // 
            this.txtRemoteHost.Location = new System.Drawing.Point(129, 40);
            this.txtRemoteHost.Name = "txtRemoteHost";
            this.txtRemoteHost.Size = new System.Drawing.Size(135, 20);
            this.txtRemoteHost.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cổng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstReceived);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSent);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstReceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSent;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.TextBox txtRemoteHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

