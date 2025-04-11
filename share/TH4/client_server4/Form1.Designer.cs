namespace client_server4
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
            this.btnGui = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.rtxMsg = new System.Windows.Forms.RichTextBox();
            this.btntKN = new System.Windows.Forms.Button();
            this.txtPortL = new System.Windows.Forms.TextBox();
            this.txtPortR = new System.Windows.Forms.TextBox();
            this.txtIPR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(567, 388);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(75, 23);
            this.btnGui.TabIndex = 19;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(12, 391);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(549, 20);
            this.txtMsg.TabIndex = 18;
            // 
            // rtxMsg
            // 
            this.rtxMsg.Location = new System.Drawing.Point(12, 89);
            this.rtxMsg.Name = "rtxMsg";
            this.rtxMsg.Size = new System.Drawing.Size(630, 266);
            this.rtxMsg.TabIndex = 17;
            this.rtxMsg.Text = "";
            // 
            // btntKN
            // 
            this.btntKN.Location = new System.Drawing.Point(371, 6);
            this.btntKN.Name = "btntKN";
            this.btntKN.Size = new System.Drawing.Size(75, 23);
            this.btntKN.TabIndex = 16;
            this.btntKN.Text = "kết nối";
            this.btntKN.UseVisualStyleBackColor = true;
            this.btntKN.Click += new System.EventHandler(this.btntKN_Click);
            // 
            // txtPortL
            // 
            this.txtPortL.Location = new System.Drawing.Point(331, 53);
            this.txtPortL.Name = "txtPortL";
            this.txtPortL.Size = new System.Drawing.Size(157, 20);
            this.txtPortL.TabIndex = 15;
            // 
            // txtPortR
            // 
            this.txtPortR.Location = new System.Drawing.Point(78, 53);
            this.txtPortR.Name = "txtPortR";
            this.txtPortR.Size = new System.Drawing.Size(157, 20);
            this.txtPortR.TabIndex = 14;
            // 
            // txtIPR
            // 
            this.txtIPR.Location = new System.Drawing.Point(78, 8);
            this.txtIPR.Name = "txtIPR";
            this.txtIPR.Size = new System.Drawing.Size(157, 20);
            this.txtIPR.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "LocalPort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "RemoteIP";
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(486, 5);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFile.TabIndex = 20;
            this.btnBrowseFile.Text = "chọn file";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(606, 5);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 21;
            this.btnSendFile.Text = "gửi file";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.rtxMsg);
            this.Controls.Add(this.btntKN);
            this.Controls.Add(this.txtPortL);
            this.Controls.Add(this.txtPortR);
            this.Controls.Add(this.txtIPR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.RichTextBox rtxMsg;
        private System.Windows.Forms.Button btntKN;
        private System.Windows.Forms.TextBox txtPortL;
        private System.Windows.Forms.TextBox txtPortR;
        private System.Windows.Forms.TextBox txtIPR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnSendFile;
    }
}

