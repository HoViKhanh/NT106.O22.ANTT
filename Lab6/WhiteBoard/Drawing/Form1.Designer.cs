namespace Drawing
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
            this.board = new System.Windows.Forms.Panel();
            this.trackBar_penWidth = new System.Windows.Forms.TrackBar();
            this.btn_end = new System.Windows.Forms.Button();
            this.btn_image = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_penWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.Dock = System.Windows.Forms.DockStyle.Top;
            this.board.Location = new System.Drawing.Point(0, 0);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(800, 359);
            this.board.TabIndex = 9;
            this.board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.board_MouseDown);
            this.board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.board_MouseMove);
            this.board.MouseUp += new System.Windows.Forms.MouseEventHandler(this.board_MouseUp);
            // 
            // trackBar_penWidth
            // 
            this.trackBar_penWidth.Location = new System.Drawing.Point(495, 380);
            this.trackBar_penWidth.Name = "trackBar_penWidth";
            this.trackBar_penWidth.Size = new System.Drawing.Size(293, 56);
            this.trackBar_penWidth.TabIndex = 8;
            // 
            // btn_end
            // 
            this.btn_end.BackColor = System.Drawing.Color.IndianRed;
            this.btn_end.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_end.Location = new System.Drawing.Point(370, 380);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(96, 47);
            this.btn_end.TabIndex = 7;
            this.btn_end.Text = "End";
            this.btn_end.UseVisualStyleBackColor = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // btn_image
            // 
            this.btn_image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_image.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_image.Location = new System.Drawing.Point(198, 380);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(166, 47);
            this.btn_image.TabIndex = 6;
            this.btn_image.Text = "Insert Image";
            this.btn_image.UseVisualStyleBackColor = false;
            // 
            // btn_color
            // 
            this.btn_color.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color.Location = new System.Drawing.Point(26, 380);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(166, 47);
            this.btn_color.TabIndex = 5;
            this.btn_color.Text = "Color";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.board);
            this.Controls.Add(this.trackBar_penWidth);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.btn_color);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_penWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.TrackBar trackBar_penWidth;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Button btn_color;
    }
}