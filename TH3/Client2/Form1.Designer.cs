namespace Client2
{
    partial class udpForm1
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnkq = new System.Windows.Forms.Button();
            this.cbbpheptoan = new System.Windows.Forms.ComboBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.lbkg = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(606, 14);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 26;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnkq
            // 
            this.btnkq.Location = new System.Drawing.Point(492, 14);
            this.btnkq.Name = "btnkq";
            this.btnkq.Size = new System.Drawing.Size(75, 23);
            this.btnkq.TabIndex = 25;
            this.btnkq.Text = "Kết quả";
            this.btnkq.UseVisualStyleBackColor = true;
            this.btnkq.Click += new System.EventHandler(this.btnkq_Click);
            // 
            // cbbpheptoan
            // 
            this.cbbpheptoan.FormattingEnabled = true;
            this.cbbpheptoan.Items.AddRange(new object[] {
            "cộng",
            "trừ",
            "nhân",
            "chia"});
            this.cbbpheptoan.Location = new System.Drawing.Point(164, 12);
            this.cbbpheptoan.Name = "cbbpheptoan";
            this.cbbpheptoan.Size = new System.Drawing.Size(71, 21);
            this.cbbpheptoan.TabIndex = 24;
            this.cbbpheptoan.Text = "Phép toán";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(379, 14);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(72, 20);
            this.txtkq.TabIndex = 23;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(282, 12);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(72, 20);
            this.txtb.TabIndex = 22;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(86, 13);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(72, 20);
            this.txta.TabIndex = 21;
            // 
            // lbkg
            // 
            this.lbkg.AutoSize = true;
            this.lbkg.Location = new System.Drawing.Point(360, 16);
            this.lbkg.Name = "lbkg";
            this.lbkg.Size = new System.Drawing.Size(13, 13);
            this.lbkg.TabIndex = 20;
            this.lbkg.Text = "=";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(254, 16);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(22, 13);
            this.lable2.TabIndex = 19;
            this.lable2.Text = "b =";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(58, 16);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(22, 13);
            this.lable1.TabIndex = 18;
            this.lable1.Text = "a =";
            // 
            // udpForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 40);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnkq);
            this.Controls.Add(this.cbbpheptoan);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbkg);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.lable1);
            this.Name = "udpForm1";
            this.Text = "udpClient2";
            this.Load += new System.EventHandler(this.udpForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnkq;
        private System.Windows.Forms.ComboBox cbbpheptoan;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label lbkg;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label lable1;
    }
}

