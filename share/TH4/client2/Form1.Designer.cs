namespace client2
{
    partial class Client2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRIP = new System.Windows.Forms.TextBox();
            this.txtLIP = new System.Windows.Forms.TextBox();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtlocalP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemoteP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfileName = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "remoteIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "localIP";
            // 
            // txtRIP
            // 
            this.txtRIP.Location = new System.Drawing.Point(80, 20);
            this.txtRIP.Name = "txtRIP";
            this.txtRIP.Size = new System.Drawing.Size(200, 20);
            this.txtRIP.TabIndex = 2;
            // 
            // txtLIP
            // 
            this.txtLIP.Location = new System.Drawing.Point(80, 65);
            this.txtLIP.Name = "txtLIP";
            this.txtLIP.Size = new System.Drawing.Size(200, 20);
            this.txtLIP.TabIndex = 3;
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(621, 58);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(75, 23);
            this.btnChonFile.TabIndex = 4;
            this.btnChonFile.Text = "chọn file";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(621, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "khỏi động";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtlocalP
            // 
            this.txtlocalP.Location = new System.Drawing.Point(406, 12);
            this.txtlocalP.Name = "txtlocalP";
            this.txtlocalP.Size = new System.Drawing.Size(127, 20);
            this.txtlocalP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "localPort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "remotelPort";
            // 
            // txtRemoteP
            // 
            this.txtRemoteP.Location = new System.Drawing.Point(406, 68);
            this.txtRemoteP.Name = "txtRemoteP";
            this.txtRemoteP.Size = new System.Drawing.Size(127, 20);
            this.txtRemoteP.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chọn file";
            // 
            // txtfileName
            // 
            this.txtfileName.Location = new System.Drawing.Point(80, 127);
            this.txtfileName.Name = "txtfileName";
            this.txtfileName.Size = new System.Drawing.Size(453, 20);
            this.txtfileName.TabIndex = 11;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFile";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(621, 120);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Client2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 180);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtfileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemoteP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlocalP);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.txtLIP);
            this.Controls.Add(this.txtRIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Client2";
            this.Text = "Client2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRIP;
        private System.Windows.Forms.TextBox txtLIP;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtlocalP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemoteP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSend;
    }
}

