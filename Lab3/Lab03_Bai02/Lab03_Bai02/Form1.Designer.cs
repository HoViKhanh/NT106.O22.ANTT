namespace Lab03_Bai02
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
            this.StartListen = new System.Windows.Forms.Button();
            this.listViewCommand = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // StartListen
            // 
            this.StartListen.Location = new System.Drawing.Point(177, 11);
            this.StartListen.Margin = new System.Windows.Forms.Padding(2);
            this.StartListen.Name = "StartListen";
            this.StartListen.Size = new System.Drawing.Size(128, 46);
            this.StartListen.TabIndex = 0;
            this.StartListen.Text = "Listen";
            this.StartListen.UseVisualStyleBackColor = true;
            this.StartListen.Click += new System.EventHandler(this.StartListen_Click_1);
            // 
            // listViewCommand
            // 
            this.listViewCommand.HideSelection = false;
            this.listViewCommand.Location = new System.Drawing.Point(12, 70);
            this.listViewCommand.Name = "listViewCommand";
            this.listViewCommand.Size = new System.Drawing.Size(476, 298);
            this.listViewCommand.TabIndex = 2;
            this.listViewCommand.UseCompatibleStateImageBehavior = false;
            this.listViewCommand.View = System.Windows.Forms.View.List;
            this.listViewCommand.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.listViewCommand);
            this.Controls.Add(this.StartListen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Lab03_Bai02";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartListen;
        private System.Windows.Forms.ListView listViewCommand;
    }
}

