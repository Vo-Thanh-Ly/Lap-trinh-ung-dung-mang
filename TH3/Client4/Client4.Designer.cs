namespace Client4
{
    partial class Client4
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblState = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fdlg = new System.Windows.Forms.OpenFileDialog();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 187);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(451, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.Location = new System.Drawing.Point(99, 46);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(57, 15);
            this.lblState.TabIndex = 19;
            this.lblState.Text = "Trạng thái";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFile.Location = new System.Drawing.Point(99, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(60, 15);
            this.lblFile.TabIndex = 18;
            this.lblFile.Text = "Tên tập tin";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(102, 138);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(140, 20);
            this.txtPort.TabIndex = 17;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(102, 90);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(140, 20);
            this.txtIP.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "IP server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tập tin";
            // 
            // fdlg
            // 
            this.fdlg.FileName = "fdlg";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(311, 88);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 70);
            this.btnSend.TabIndex = 22;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(311, 12);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(64, 23);
            this.btnChonFile.TabIndex = 21;
            this.btnChonFile.Text = "Chọn file";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // Client4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 240);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnChonFile);
            this.Name = "Client4";
            this.Text = "Client4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog fdlg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnChonFile;
    }
}

