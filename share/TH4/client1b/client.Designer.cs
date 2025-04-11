namespace TH4
{
    partial class Client
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
            this.txtIPR = new System.Windows.Forms.TextBox();
            this.txtPortR = new System.Windows.Forms.TextBox();
            this.txtPortL = new System.Windows.Forms.TextBox();
            this.btntKN = new System.Windows.Forms.Button();
            this.rtxMsg = new System.Windows.Forms.RichTextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RemoteIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
   
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LocalPort";
            // 
            // txtIPR
            // 
            this.txtIPR.Location = new System.Drawing.Point(96, 22);
            this.txtIPR.Name = "txtIPR";
            this.txtIPR.Size = new System.Drawing.Size(157, 20);
            this.txtIPR.TabIndex = 3;
            // 
            // txtPortR
            // 
            this.txtPortR.Location = new System.Drawing.Point(96, 67);
            this.txtPortR.Name = "txtPortR";
            this.txtPortR.Size = new System.Drawing.Size(157, 20);
            this.txtPortR.TabIndex = 4;
            // 
            // txtPortL
            // 
            this.txtPortL.Location = new System.Drawing.Point(349, 67);
            this.txtPortL.Name = "txtPortL";
            this.txtPortL.Size = new System.Drawing.Size(157, 20);
            this.txtPortL.TabIndex = 5;
            // 
            // btntKN
            // 
            this.btntKN.Location = new System.Drawing.Point(585, 25);
            this.btntKN.Name = "btntKN";
            this.btntKN.Size = new System.Drawing.Size(75, 23);
            this.btntKN.TabIndex = 6;
            this.btntKN.Text = "kết nối";
            this.btntKN.UseVisualStyleBackColor = true;
            this.btntKN.Click += new System.EventHandler(this.btntKN_Click);
            // 
            // rtxMsg
            // 
            this.rtxMsg.Location = new System.Drawing.Point(30, 103);
            this.rtxMsg.Name = "rtxMsg";
            this.rtxMsg.Size = new System.Drawing.Size(630, 266);
            this.rtxMsg.TabIndex = 7;
            this.rtxMsg.Text = "";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(30, 405);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(549, 20);
            this.txtMsg.TabIndex = 8;
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(585, 402);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(75, 23);
            this.btnGui.TabIndex = 9;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIPR;
        private System.Windows.Forms.TextBox txtPortR;
        private System.Windows.Forms.TextBox txtPortL;
        private System.Windows.Forms.Button btntKN;
        private System.Windows.Forms.RichTextBox rtxMsg;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnGui;
    }
}

