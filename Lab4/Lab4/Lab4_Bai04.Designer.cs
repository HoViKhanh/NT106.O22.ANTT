namespace Lab4
{
    partial class Lab4_Bai04
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
            this.tb_url = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnTab = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.webBrowser = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl.SuspendLayout();
            this.webBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(9, 10);
            this.tb_url.Margin = new System.Windows.Forms.Padding(2);
            this.tb_url.Multiline = true;
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(426, 32);
            this.tb_url.TabIndex = 0;
            this.tb_url.TextChanged += new System.EventHandler(this.tb_url_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(439, 12);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 29);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(523, 12);
            this.btnForward.Margin = new System.Windows.Forms.Padding(2);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(74, 29);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "->";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(612, 12);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 29);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(680, 10);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(91, 35);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnTab
            // 
            this.btnTab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab.Location = new System.Drawing.Point(776, 10);
            this.btnTab.Margin = new System.Windows.Forms.Padding(2);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(91, 35);
            this.btnTab.TabIndex = 5;
            this.btnTab.Text = "New tab";
            this.btnTab.UseVisualStyleBackColor = true;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(823, 523);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(91, 35);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View code";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(918, 523);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(91, 35);
            this.btnDownload.TabIndex = 7;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.webBrowser);
            this.tabControl.Location = new System.Drawing.Point(9, 55);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 464);
            this.tabControl.TabIndex = 8;
            // 
            // webBrowser
            // 
            this.webBrowser.Controls.Add(this.webBrowser1);
            this.webBrowser.Location = new System.Drawing.Point(4, 22);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Padding = new System.Windows.Forms.Padding(2);
            this.webBrowser.Size = new System.Drawing.Size(992, 438);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Text = "tabPage1";
            this.webBrowser.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(2, 2);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(988, 434);
            this.webBrowser1.TabIndex = 0;
            // 
            // Lab4_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 569);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tb_url);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lab4_Bai04";
            this.Text = "Lab4_Bai04";
            this.Load += new System.EventHandler(this.Lab4_Bai04_Load);
            this.tabControl.ResumeLayout(false);
            this.webBrowser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage webBrowser;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}