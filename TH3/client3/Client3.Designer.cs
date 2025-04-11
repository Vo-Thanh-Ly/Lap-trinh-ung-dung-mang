namespace client3
{
    partial class Client3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fdlg = new System.Windows.Forms.OpenFileDialog();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tập tin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP server";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(87, 90);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(140, 20);
            this.txtIP.TabIndex = 4;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(87, 138);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(140, 20);
            this.txtPort.TabIndex = 5;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFile.Location = new System.Drawing.Point(84, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(60, 15);
            this.lblFile.TabIndex = 7;
            this.lblFile.Text = "Tên tập tin";
            this.lblFile.Click += new System.EventHandler(this.lblFile_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.Location = new System.Drawing.Point(84, 46);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(57, 15);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "Trạng thái";
            this.lblState.Click += new System.EventHandler(this.lblState_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 187);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(451, 23);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // fdlg
            // 
            this.fdlg.FileName = "fdlg";
            this.fdlg.FileOk += new System.ComponentModel.CancelEventHandler(this.fdlg_FileOk);
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(296, 12);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(64, 23);
            this.btnChonFile.TabIndex = 10;
            this.btnChonFile.Text = "Chọn file";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(296, 88);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 70);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Client3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 244);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Client3";
            this.Text = "Client3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog fdlg;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Button btnSend;
    }
}

