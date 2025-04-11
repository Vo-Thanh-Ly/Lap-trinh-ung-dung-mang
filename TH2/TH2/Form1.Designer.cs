namespace TH2
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
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstSent = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.lstReceived = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(26, 415);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(344, 20);
            this.txtSend.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(376, 415);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(37, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstSent
            // 
            this.lstSent.FormattingEnabled = true;
            this.lstSent.Location = new System.Drawing.Point(26, 35);
            this.lstSent.Name = "lstSent";
            this.lstSent.Size = new System.Drawing.Size(387, 160);
            this.lstSent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tin nhắn  nhận về";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tin nhắn gửi";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(490, 412);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(214, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIpAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(447, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông số máy nhận";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cổng";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(129, 40);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(135, 20);
            this.txtIpAddress.TabIndex = 7;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(129, 78);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(135, 20);
            this.txtPort.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cổng truyền thông";
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Location = new System.Drawing.Point(576, 223);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(135, 20);
            this.txtLocalPort.TabIndex = 10;
            // 
            // lstReceived
            // 
            this.lstReceived.FormattingEnabled = true;
            this.lstReceived.Location = new System.Drawing.Point(26, 226);
            this.lstReceived.Name = "lstReceived";
            this.lstReceived.Size = new System.Drawing.Size(387, 147);
            this.lstReceived.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tin nhắn  gửi đi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstReceived);
            this.Controls.Add(this.txtLocalPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSent);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstSent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.ListBox lstReceived;
        private System.Windows.Forms.Label label6;
    }
}

