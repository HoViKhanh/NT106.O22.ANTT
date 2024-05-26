namespace Lab4
{
    partial class Lab4_Bai02
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tb_url = new System.Windows.Forms.TextBox();
            this.tb_ = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tb_url
            // 
            this.tb_url.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_url.Location = new System.Drawing.Point(108, 12);
            this.tb_url.Multiline = true;
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(539, 34);
            this.tb_url.TabIndex = 5;
            // 
            // tb_
            // 
            this.tb_.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_.Location = new System.Drawing.Point(108, 52);
            this.tb_.Multiline = true;
            this.tb_.Name = "tb_";
            this.tb_.Size = new System.Drawing.Size(539, 34);
            this.tb_.TabIndex = 7;
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(672, 28);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(116, 34);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 93);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 340);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Lab4_Bai02
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.tb_);
            this.Controls.Add(this.tb_url);
            this.Name = "Lab4_Bai02";
            this.Text = "Lab4_Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.TextBox tb_;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
