namespace WindowsFormsApp1
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
            this.sendBtn = new System.Windows.Forms.Button();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.bodyTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pwdTB = new System.Windows.Forms.TextBox();
            this.subTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sendBtn.Location = new System.Drawing.Point(40, 43);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(121, 45);
            this.sendBtn.TabIndex = 0;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // fromTB
            // 
            this.fromTB.Location = new System.Drawing.Point(307, 40);
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(206, 22);
            this.fromTB.TabIndex = 1;
            this.fromTB.Text = "vikhanh@nhom12.nt106";
            this.fromTB.TextChanged += new System.EventHandler(this.fromTB_TextChanged);
            // 
            // bodyTB
            // 
            this.bodyTB.Location = new System.Drawing.Point(203, 182);
            this.bodyTB.Name = "bodyTB";
            this.bodyTB.Size = new System.Drawing.Size(557, 271);
            this.bodyTB.TabIndex = 2;
            this.bodyTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "From: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // toTB
            // 
            this.toTB.Location = new System.Drawing.Point(307, 72);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(206, 22);
            this.toTB.TabIndex = 5;
            this.toTB.Text = "vikhanh@nhom12.nt106";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // pwdTB
            // 
            this.pwdTB.Location = new System.Drawing.Point(603, 43);
            this.pwdTB.Name = "pwdTB";
            this.pwdTB.Size = new System.Drawing.Size(157, 22);
            this.pwdTB.TabIndex = 6;
            this.pwdTB.Text = "Nt106Uit@@";
            // 
            // subTB
            // 
            this.subTB.Location = new System.Drawing.Point(203, 137);
            this.subTB.Name = "subTB";
            this.subTB.Size = new System.Drawing.Size(557, 22);
            this.subTB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Body:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(861, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pwdTB);
            this.Controls.Add(this.toTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bodyTB);
            this.Controls.Add(this.fromTB);
            this.Controls.Add(this.sendBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.RichTextBox bodyTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pwdTB;
        private System.Windows.Forms.TextBox subTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

