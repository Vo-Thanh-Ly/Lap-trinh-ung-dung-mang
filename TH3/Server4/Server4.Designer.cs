namespace Server4
{
    partial class Server4
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
            this.buttonThoat = new System.Windows.Forms.Button();
            this.lstConnect = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(352, 61);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 9;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // lstConnect
            // 
            this.lstConnect.FormattingEnabled = true;
            this.lstConnect.Location = new System.Drawing.Point(63, 44);
            this.lstConnect.Name = "lstConnect";
            this.lstConnect.Size = new System.Drawing.Size(227, 160);
            this.lstConnect.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(352, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Khởi động";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(63, 5);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(227, 20);
            this.txtPort.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cổng";
            // 
            // Server4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 221);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.lstConnect);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Name = "Server4";
            this.Text = "Server4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.ListBox lstConnect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
    }
}

