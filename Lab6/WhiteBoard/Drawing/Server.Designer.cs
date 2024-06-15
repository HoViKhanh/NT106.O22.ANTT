namespace Drawing
{
    partial class Server
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
            this.lb_client = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.tb_client = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_client
            // 
            this.lb_client.AutoSize = true;
            this.lb_client.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_client.Location = new System.Drawing.Point(146, 136);
            this.lb_client.Name = "lb_client";
            this.lb_client.Size = new System.Drawing.Size(69, 24);
            this.lb_client.TabIndex = 0;
            this.lb_client.Text = "Client: ";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.LightGreen;
            this.btn_start.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(215, 30);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(144, 68);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            // 
            // tb_client
            // 
            this.tb_client.Location = new System.Drawing.Point(215, 137);
            this.tb_client.Name = "tb_client";
            this.tb_client.Size = new System.Drawing.Size(144, 22);
            this.tb_client.TabIndex = 2;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 202);
            this.Controls.Add(this.tb_client);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lb_client);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_client;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox tb_client;
    }
}