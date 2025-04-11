namespace TH2C2
{
    partial class KiemTraHaiTenMien
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
            this.textTM1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textTM2 = new System.Windows.Forms.TextBox();
            this.btnkt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTM1
            // 
            this.textTM1.Location = new System.Drawing.Point(105, 28);
            this.textTM1.Name = "textTM1";
            this.textTM1.Size = new System.Drawing.Size(236, 20);
            this.textTM1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên miền 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên miền 2";
            // 
            // textTM2
            // 
            this.textTM2.Location = new System.Drawing.Point(105, 80);
            this.textTM2.Name = "textTM2";
            this.textTM2.Size = new System.Drawing.Size(236, 20);
            this.textTM2.TabIndex = 3;
            // 
            // btnkt
            // 
            this.btnkt.Location = new System.Drawing.Point(265, 146);
            this.btnkt.Name = "btnkt";
            this.btnkt.Size = new System.Drawing.Size(75, 23);
            this.btnkt.TabIndex = 4;
            this.btnkt.Text = "Kiểm tra";
            this.btnkt.UseVisualStyleBackColor = true;
            this.btnkt.Click += new System.EventHandler(this.btnkt_Click);
            // 
            // KiemTraHaiTenMien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 181);
            this.Controls.Add(this.btnkt);
            this.Controls.Add(this.textTM2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTM1);
            this.Name = "KiemTraHaiTenMien";
            this.Text = "KiemTraHaiTenMien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTM1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTM2;
        private System.Windows.Forms.Button btnkt;
    }
}