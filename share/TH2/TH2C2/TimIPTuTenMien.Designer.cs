namespace TH2C2
{
    partial class TimIPTuTenMien
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.listIP = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(39, 52);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(346, 20);
            this.txtIP.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(413, 50);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // listIP
            // 
            this.listIP.FormattingEnabled = true;
            this.listIP.Location = new System.Drawing.Point(39, 106);
            this.listIP.Name = "listIP";
            this.listIP.Size = new System.Drawing.Size(346, 264);
            this.listIP.TabIndex = 2;
            // 
            // TimIPTuTenMien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 374);
            this.Controls.Add(this.listIP);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtIP);
            this.Name = "TimIPTuTenMien";
            this.Text = "Tìm địa chỉ IP từ tên miền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ListBox listIP;
    }
}