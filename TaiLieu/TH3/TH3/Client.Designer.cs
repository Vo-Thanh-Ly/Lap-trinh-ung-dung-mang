﻿namespace TH3
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
            this.txta = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.Label();
            this.lbkg = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.cbbpheptoan = new System.Windows.Forms.ComboBox();
            this.btnkq = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txta
            // 
            this.txta.AutoSize = true;
            this.txta.Location = new System.Drawing.Point(4, 25);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(22, 13);
            this.txta.TabIndex = 0;
            this.txta.Text = "a =";
            // 
            // txtb
            // 
            this.txtb.AutoSize = true;
            this.txtb.Location = new System.Drawing.Point(200, 25);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(22, 13);
            this.txtb.TabIndex = 1;
            this.txtb.Text = "b =";
            // 
            // lbkg
            // 
            this.lbkg.AutoSize = true;
            this.lbkg.Location = new System.Drawing.Point(306, 25);
            this.lbkg.Name = "lbkg";
            this.lbkg.Size = new System.Drawing.Size(13, 13);
            this.lbkg.TabIndex = 2;
            this.lbkg.Text = "=";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 20);
            this.textBox2.TabIndex = 4;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(325, 23);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(72, 20);
            this.txtkq.TabIndex = 5;
            // 
            // cbbpheptoan
            // 
            this.cbbpheptoan.FormattingEnabled = true;
            this.cbbpheptoan.Items.AddRange(new object[] {
            "cộng",
            "trừ",
            "nhân",
            "chia"});
            this.cbbpheptoan.Location = new System.Drawing.Point(110, 21);
            this.cbbpheptoan.Name = "cbbpheptoan";
            this.cbbpheptoan.Size = new System.Drawing.Size(71, 21);
            this.cbbpheptoan.TabIndex = 6;
            this.cbbpheptoan.Text = "Phép toán";
            // 
            // btnkq
            // 
            this.btnkq.Location = new System.Drawing.Point(438, 23);
            this.btnkq.Name = "btnkq";
            this.btnkq.Size = new System.Drawing.Size(75, 23);
            this.btnkq.TabIndex = 7;
            this.btnkq.Text = "Kết quả";
            this.btnkq.UseVisualStyleBackColor = true;
            this.btnkq.Click += new System.EventHandler(this.btnkq_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(552, 23);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 68);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnkq);
            this.Controls.Add(this.cbbpheptoan);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbkg);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txta;
        private System.Windows.Forms.Label txtb;
        private System.Windows.Forms.Label lbkg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.ComboBox cbbpheptoan;
        private System.Windows.Forms.Button btnkq;
        private System.Windows.Forms.Button btnthoat;
    }
}