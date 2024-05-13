namespace Lab4
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBai1 = new System.Windows.Forms.Button();
            this.btnBai2 = new System.Windows.Forms.Button();
            this.btnBai3 = new System.Windows.Forms.Button();
            this.btnBai4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(318, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 70);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBai1
            // 
            this.btnBai1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBai1.Location = new System.Drawing.Point(140, 55);
            this.btnBai1.Name = "btnBai1";
            this.btnBai1.Size = new System.Drawing.Size(191, 79);
            this.btnBai1.TabIndex = 1;
            this.btnBai1.Text = "Bai01";
            this.btnBai1.UseVisualStyleBackColor = false;
            this.btnBai1.Click += new System.EventHandler(this.btnBai1_Click);
            // 
            // btnBai2
            // 
            this.btnBai2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBai2.Location = new System.Drawing.Point(445, 55);
            this.btnBai2.Name = "btnBai2";
            this.btnBai2.Size = new System.Drawing.Size(191, 79);
            this.btnBai2.TabIndex = 2;
            this.btnBai2.Text = "Bai02";
            this.btnBai2.UseVisualStyleBackColor = false;
            this.btnBai2.Click += new System.EventHandler(this.btnBai2_Click);
            // 
            // btnBai3
            // 
            this.btnBai3.BackColor = System.Drawing.Color.Cyan;
            this.btnBai3.Location = new System.Drawing.Point(140, 182);
            this.btnBai3.Name = "btnBai3";
            this.btnBai3.Size = new System.Drawing.Size(191, 79);
            this.btnBai3.TabIndex = 3;
            this.btnBai3.Text = "Bai03";
            this.btnBai3.UseVisualStyleBackColor = false;
            this.btnBai3.Click += new System.EventHandler(this.btnBai3_Click);
            // 
            // btnBai4
            // 
            this.btnBai4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBai4.Location = new System.Drawing.Point(445, 182);
            this.btnBai4.Name = "btnBai4";
            this.btnBai4.Size = new System.Drawing.Size(191, 79);
            this.btnBai4.TabIndex = 4;
            this.btnBai4.Text = "Bai04";
            this.btnBai4.UseVisualStyleBackColor = false;
            this.btnBai4.Click += new System.EventHandler(this.btnBai4_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBai4);
            this.Controls.Add(this.btnBai3);
            this.Controls.Add(this.btnBai2);
            this.Controls.Add(this.btnBai1);
            this.Controls.Add(this.btnExit);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBai1;
        private System.Windows.Forms.Button btnBai2;
        private System.Windows.Forms.Button btnBai3;
        private System.Windows.Forms.Button btnBai4;
    }
}