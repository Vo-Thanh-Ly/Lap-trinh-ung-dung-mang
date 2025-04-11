namespace TH2C2
{
    partial class KiemTraIPv4_Ipv6
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnkt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ IP cần kiểm tra :";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(150, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(311, 20);
            this.txtIP.TabIndex = 1;
            // 
            // btnkt
            // 
            this.btnkt.Location = new System.Drawing.Point(488, 17);
            this.btnkt.Name = "btnkt";
            this.btnkt.Size = new System.Drawing.Size(75, 23);
            this.btnkt.TabIndex = 2;
            this.btnkt.Text = "Kiểm tra";
            this.btnkt.UseVisualStyleBackColor = true;
            this.btnkt.Click += new System.EventHandler(this.btnkt_Click);
            // 
            // KiemTraIPv4_Ipv6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 61);
            this.Controls.Add(this.btnkt);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "KiemTraIPv4_Ipv6";
            this.Text = "Kiểm tra phiên bản địa chỉ IP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnkt;
    }
}