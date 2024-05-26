namespace Home
{
    partial class Home
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
            this.btn_Bai1_Client = new System.Windows.Forms.Button();
            this.btn_Bai1_Server = new System.Windows.Forms.Button();
            this.btn_Bai2 = new System.Windows.Forms.Button();
            this.btn_Bai3_Client = new System.Windows.Forms.Button();
            this.btn_Bai4_Client = new System.Windows.Forms.Button();
            this.btn_Bai3_Server = new System.Windows.Forms.Button();
            this.btn_Bai4_Server = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Bai1_Client
            // 
            this.btn_Bai1_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Bai1_Client.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai1_Client.Location = new System.Drawing.Point(107, 12);
            this.btn_Bai1_Client.Name = "btn_Bai1_Client";
            this.btn_Bai1_Client.Size = new System.Drawing.Size(200, 40);
            this.btn_Bai1_Client.TabIndex = 0;
            this.btn_Bai1_Client.Text = "UDPClient";
            this.btn_Bai1_Client.UseVisualStyleBackColor = false;
            this.btn_Bai1_Client.Click += new System.EventHandler(this.btn_Bai1_Client_Click);
            // 
            // btn_Bai1_Server
            // 
            this.btn_Bai1_Server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Bai1_Server.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai1_Server.Location = new System.Drawing.Point(335, 12);
            this.btn_Bai1_Server.Name = "btn_Bai1_Server";
            this.btn_Bai1_Server.Size = new System.Drawing.Size(200, 40);
            this.btn_Bai1_Server.TabIndex = 0;
            this.btn_Bai1_Server.Text = "UDPServer";
            this.btn_Bai1_Server.UseVisualStyleBackColor = false;
            this.btn_Bai1_Server.Click += new System.EventHandler(this.btn_Bai1_Server_Click);
            // 
            // btn_Bai2
            // 
            this.btn_Bai2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Bai2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai2.Location = new System.Drawing.Point(335, 58);
            this.btn_Bai2.Name = "btn_Bai2";
            this.btn_Bai2.Size = new System.Drawing.Size(200, 40);
            this.btn_Bai2.TabIndex = 0;
            this.btn_Bai2.Text = "TCPServer";
            this.btn_Bai2.UseVisualStyleBackColor = false;
            this.btn_Bai2.Click += new System.EventHandler(this.btn_Bai2_Click);
            // 
            // btn_Bai3_Client
            // 
            this.btn_Bai3_Client.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_Bai3_Client.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai3_Client.Location = new System.Drawing.Point(107, 104);
            this.btn_Bai3_Client.Name = "btn_Bai3_Client";
            this.btn_Bai3_Client.Size = new System.Drawing.Size(200, 40);
            this.btn_Bai3_Client.TabIndex = 0;
            this.btn_Bai3_Client.Text = "TCPClient";
            this.btn_Bai3_Client.UseVisualStyleBackColor = false;
            this.btn_Bai3_Client.Click += new System.EventHandler(this.btn_Bai3_Client_Click);
            // 
            // btn_Bai4_Client
            // 
            this.btn_Bai4_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Bai4_Client.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai4_Client.Location = new System.Drawing.Point(107, 150);
            this.btn_Bai4_Client.Name = "btn_Bai4_Client";
            this.btn_Bai4_Client.Size = new System.Drawing.Size(200, 40);
            this.btn_Bai4_Client.TabIndex = 0;
            this.btn_Bai4_Client.Text = "MultiClient";
            this.btn_Bai4_Client.UseVisualStyleBackColor = false;
            this.btn_Bai4_Client.Click += new System.EventHandler(this.btn_Bai4_Client_Click);
            // 
            // btn_Bai3_Server
            // 
            this.btn_Bai3_Server.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_Bai3_Server.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai3_Server.Location = new System.Drawing.Point(335, 104);
            this.btn_Bai3_Server.Name = "btn_Bai3_Server";
            this.btn_Bai3_Server.Size = new System.Drawing.Size(200, 40);
            this.btn_Bai3_Server.TabIndex = 0;
            this.btn_Bai3_Server.Text = "TCPServer";
            this.btn_Bai3_Server.UseVisualStyleBackColor = false;
            this.btn_Bai3_Server.Click += new System.EventHandler(this.btn_Bai3_Server_Click);
            // 
            // btn_Bai4_Server
            // 
            this.btn_Bai4_Server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Bai4_Server.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai4_Server.Location = new System.Drawing.Point(335, 150);
            this.btn_Bai4_Server.Name = "btn_Bai4_Server";
            this.btn_Bai4_Server.Size = new System.Drawing.Size(200, 40);
            this.btn_Bai4_Server.TabIndex = 0;
            this.btn_Bai4_Server.Text = "Server";
            this.btn_Bai4_Server.UseVisualStyleBackColor = false;
            this.btn_Bai4_Server.Click += new System.EventHandler(this.btn_Bai4_Server_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bài 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bài 2";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bài 3";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bài 4";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(27, 205);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(508, 33);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 250);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Bai4_Server);
            this.Controls.Add(this.btn_Bai3_Server);
            this.Controls.Add(this.btn_Bai4_Client);
            this.Controls.Add(this.btn_Bai3_Client);
            this.Controls.Add(this.btn_Bai2);
            this.Controls.Add(this.btn_Bai1_Server);
            this.Controls.Add(this.btn_Bai1_Client);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 3 Thực hành Lập trình mạng căn bản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Bai1_Client;
        private System.Windows.Forms.Button btn_Bai1_Server;
        private System.Windows.Forms.Button btn_Bai2;
        private System.Windows.Forms.Button btn_Bai3_Client;
        private System.Windows.Forms.Button btn_Bai4_Client;
        private System.Windows.Forms.Button btn_Bai3_Server;
        private System.Windows.Forms.Button btn_Bai4_Server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Exit;
    }
}

