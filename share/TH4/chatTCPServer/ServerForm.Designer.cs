namespace chatTCPServer
{
    partial class ServerForm
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
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(177, 288);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(164, 20);
            this.txtPort.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(31, 44);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(410, 204);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(376, 288);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(65, 20);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cổng ";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtPort);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
    }
}

