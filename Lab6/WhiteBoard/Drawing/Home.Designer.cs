namespace Drawing
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
            this.btn_server = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_server
            // 
            this.btn_server.Location = new System.Drawing.Point(94, 72);
            this.btn_server.Name = "btn_server";
            this.btn_server.Size = new System.Drawing.Size(170, 90);
            this.btn_server.TabIndex = 0;
            this.btn_server.Text = "Server";
            this.btn_server.UseVisualStyleBackColor = true;
            this.btn_server.Click += new System.EventHandler(this.btn_server_Click);
            // 
            // btn_client
            // 
            this.btn_client.Location = new System.Drawing.Point(379, 72);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(170, 90);
            this.btn_client.TabIndex = 1;
            this.btn_client.Text = "Add Client";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 275);
            this.Controls.Add(this.btn_client);
            this.Controls.Add(this.btn_server);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_server;
        private System.Windows.Forms.Button btn_client;
    }
}