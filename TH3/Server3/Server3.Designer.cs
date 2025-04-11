namespace Server3
{
    partial class Server3
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
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstConnect = new System.Windows.Forms.ListBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cổng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(82, 15);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(227, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(371, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Khởi động";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstConnect
            // 
            this.lstConnect.FormattingEnabled = true;
            this.lstConnect.Location = new System.Drawing.Point(82, 54);
            this.lstConnect.Name = "lstConnect";
            this.lstConnect.Size = new System.Drawing.Size(227, 160);
            this.lstConnect.TabIndex = 3;
            this.lstConnect.SelectedIndexChanged += new System.EventHandler(this.lstConnect_SelectedIndexChanged);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(371, 71);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 4;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // Server3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 230);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.lstConnect);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Name = "Server3";
            this.Text = "Server3";
            this.Load += new System.EventHandler(this.Server3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstConnect;
        private System.Windows.Forms.Button buttonThoat;
    }
}

