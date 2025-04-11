namespace TH2C2
{
    partial class IPMayCucBo
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
            this.listIP = new System.Windows.Forms.ListBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listIP
            // 
            this.listIP.FormattingEnabled = true;
            this.listIP.Location = new System.Drawing.Point(27, 65);
            this.listIP.Name = "listIP";
            this.listIP.Size = new System.Drawing.Size(346, 264);
            this.listIP.TabIndex = 5;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(401, 9);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Địa chỉ IP của máy cục bộ";
            // 
            // IPMayCucBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listIP);
            this.Controls.Add(this.btnTim);
            this.Name = "IPMayCucBo";
            this.Text = "IPMayCucBo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listIP;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
    }
}