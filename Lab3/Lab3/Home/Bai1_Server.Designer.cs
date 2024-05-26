namespace Home
{
    partial class Bai1_Server
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
            this.messagelist1 = new System.Windows.Forms.ListView();
            this.ServerPortB1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnB1Listen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(262, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 51);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // messagelist1
            // 
            this.messagelist1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.messagelist1.HideSelection = false;
            this.messagelist1.Location = new System.Drawing.Point(34, 152);
            this.messagelist1.Name = "messagelist1";
            this.messagelist1.Size = new System.Drawing.Size(580, 214);
            this.messagelist1.TabIndex = 16;
            this.messagelist1.UseCompatibleStateImageBehavior = false;
            this.messagelist1.View = System.Windows.Forms.View.List;
            // 
            // ServerPortB1
            // 
            this.ServerPortB1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServerPortB1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerPortB1.Location = new System.Drawing.Point(34, 64);
            this.ServerPortB1.Name = "ServerPortB1";
            this.ServerPortB1.Size = new System.Drawing.Size(270, 34);
            this.ServerPortB1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Received Message";
            // 
            // btnB1Listen
            // 
            this.btnB1Listen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnB1Listen.BackColor = System.Drawing.Color.Aquamarine;
            this.btnB1Listen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB1Listen.Location = new System.Drawing.Point(436, 45);
            this.btnB1Listen.Name = "btnB1Listen";
            this.btnB1Listen.Size = new System.Drawing.Size(178, 70);
            this.btnB1Listen.TabIndex = 13;
            this.btnB1Listen.Text = "Listen";
            this.btnB1Listen.UseVisualStyleBackColor = false;
            this.btnB1Listen.Click += new System.EventHandler(this.btnB1Listen_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Port";
            // 
            // Bai1_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 435);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.messagelist1);
            this.Controls.Add(this.ServerPortB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnB1Listen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Bai1_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai1_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView messagelist1;
        private System.Windows.Forms.TextBox ServerPortB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnB1Listen;
        private System.Windows.Forms.Label label1;
    }
}