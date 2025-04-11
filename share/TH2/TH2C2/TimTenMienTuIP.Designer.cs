namespace TH2C2
{
    partial class TimTenMienTuIP
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
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTenMien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTenMine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(513, 10);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTenMien
            // 
            this.txtTenMien.Location = new System.Drawing.Point(139, 12);
            this.txtTenMien.Name = "txtTenMien";
            this.txtTenMien.Size = new System.Drawing.Size(346, 20);
            this.txtTenMien.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên miền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Địa chỉ IP";
            // 
            // labelTenMine
            // 
            this.labelTenMine.AutoSize = true;
            this.labelTenMine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTenMine.Location = new System.Drawing.Point(148, 53);
            this.labelTenMine.Name = "labelTenMine";
            this.labelTenMine.Size = new System.Drawing.Size(33, 15);
            this.labelTenMine.TabIndex = 7;
            this.labelTenMine.Text = "none";
            // 
            // TimTenMienTuIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 108);
            this.Controls.Add(this.labelTenMine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTenMien);
            this.Name = "TimTenMienTuIP";
            this.Text = "TimTenMienTuIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTenMien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTenMine;
    }
}