namespace chatTcpClient
{
    partial class ClientForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(622, 311);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 43;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(67, 314);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(549, 20);
            this.txtMessage.TabIndex = 42;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(67, 106);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(630, 178);
            this.txtChat.TabIndex = 41;
            this.txtChat.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(426, 23);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 40;
            this.btnConnect.Text = "kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(133, 70);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(157, 20);
            this.txtPort.TabIndex = 38;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(133, 25);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(157, 20);
            this.txtServerIP.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "RemoteIP";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 344);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

