namespace Drawing
{
    partial class Client
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
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_image = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.board = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_color
            // 
            this.btn_color.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color.Location = new System.Drawing.Point(26, 377);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(166, 47);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "Color";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_image
            // 
            this.btn_image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_image.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_image.Location = new System.Drawing.Point(198, 377);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(166, 47);
            this.btn_image.TabIndex = 1;
            this.btn_image.Text = "Insert Image";
            this.btn_image.UseVisualStyleBackColor = false;
            // 
            // btn_end
            // 
            this.btn_end.BackColor = System.Drawing.Color.IndianRed;
            this.btn_end.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_end.Location = new System.Drawing.Point(370, 377);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(96, 47);
            this.btn_end.TabIndex = 2;
            this.btn_end.Text = "End";
            this.btn_end.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(495, 377);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(293, 56);
            this.trackBar1.TabIndex = 3;
            // 
            // board
            // 
            this.board.Location = new System.Drawing.Point(13, 12);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(762, 359);
            this.board.TabIndex = 4;
            this.board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.board_MouseDown);
            this.board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.board_MouseMove);
            this.board.MouseUp += new System.Windows.Forms.MouseEventHandler(this.board_MouseUp);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.board);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.btn_color);
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel board;
    }
}