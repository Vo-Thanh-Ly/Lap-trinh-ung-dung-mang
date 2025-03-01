namespace UDPChatSimple
{
    partial class Form1
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
            this.txtIPR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortL = new System.Windows.Forms.TextBox();
            this.btnKN = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.txtPortR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnsent = new System.Windows.Forms.Button();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remote IP:";
            // 
            // txtIPR
            // 
            this.txtIPR.Location = new System.Drawing.Point(111, 24);
            this.txtIPR.Margin = new System.Windows.Forms.Padding(4);
            this.txtIPR.Name = "txtIPR";
            this.txtIPR.Size = new System.Drawing.Size(206, 22);
            this.txtIPR.TabIndex = 1;
            this.txtIPR.Text = "txtIPR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local Port:";
            // 
            // txtPortL
            // 
            this.txtPortL.Location = new System.Drawing.Point(259, 58);
            this.txtPortL.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortL.MaxLength = 4;
            this.txtPortL.Name = "txtPortL";
            this.txtPortL.Size = new System.Drawing.Size(60, 22);
            this.txtPortL.TabIndex = 3;
            this.txtPortL.Text = "txtPortL";
            // 
            // btnKN
            // 
            this.btnKN.Location = new System.Drawing.Point(327, 23);
            this.btnKN.Margin = new System.Windows.Forms.Padding(4);
            this.btnKN.Name = "btnKN";
            this.btnKN.Size = new System.Drawing.Size(117, 27);
            this.btnKN.TabIndex = 4;
            this.btnKN.Text = "Connect";
            this.btnKN.UseVisualStyleBackColor = true;
            this.btnKN.Click += new System.EventHandler(this.btnKN_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(16, 289);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(4);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(340, 22);
            this.txtMsg.TabIndex = 6;
            this.txtMsg.Text = "txtMsg";
            // 
            // btnGui
            // 
            this.btnGui.Enabled = false;
            this.btnGui.Location = new System.Drawing.Point(364, 288);
            this.btnGui.Margin = new System.Windows.Forms.Padding(4);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(101, 25);
            this.btnGui.TabIndex = 7;
            this.btnGui.Text = "Send";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // txtPortR
            // 
            this.txtPortR.Location = new System.Drawing.Point(111, 58);
            this.txtPortR.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortR.MaxLength = 4;
            this.txtPortR.Name = "txtPortR";
            this.txtPortR.Size = new System.Drawing.Size(62, 22);
            this.txtPortR.TabIndex = 8;
            this.txtPortR.Text = "txtPortR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Remote Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnKN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIPR);
            this.groupBox1.Controls.Add(this.txtPortR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPortL);
            this.groupBox1.Location = new System.Drawing.Point(16, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(449, 121);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unsent: Select your message then click Unsent";
            // 
            // btnUnsent
            // 
            this.btnUnsent.Location = new System.Drawing.Point(364, 133);
            this.btnUnsent.Name = "btnUnsent";
            this.btnUnsent.Size = new System.Drawing.Size(101, 86);
            this.btnUnsent.TabIndex = 13;
            this.btnUnsent.Text = "Unsent";
            this.btnUnsent.UseVisualStyleBackColor = true;
            this.btnUnsent.Click += new System.EventHandler(this.btnUnsent_Click);
            // 
            // lstMsg
            // 
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.ItemHeight = 16;
            this.lstMsg.Location = new System.Drawing.Point(16, 133);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(340, 148);
            this.lstMsg.TabIndex = 14;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(364, 225);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(101, 56);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 324);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lstMsg);
            this.Controls.Add(this.btnUnsent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.txtMsg);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple UDP Chat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPortL;
        private System.Windows.Forms.Button btnKN;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.TextBox txtPortR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUnsent;
        private System.Windows.Forms.ListBox lstMsg;
        private System.Windows.Forms.Button btnClearAll;
    }
}

