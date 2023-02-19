
namespace MovieApp.User
{
    partial class info
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
            this.txtTITLE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtACTOR = new System.Windows.Forms.Label();
            this.txtDRECTOR = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTITLE
            // 
            this.txtTITLE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTITLE.Location = new System.Drawing.Point(240, 88);
            this.txtTITLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTITLE.Name = "txtTITLE";
            this.txtTITLE.Size = new System.Drawing.Size(392, 24);
            this.txtTITLE.TabIndex = 1;
            this.txtTITLE.Text = "제목";
            this.txtTITLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 296);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtACTOR
            // 
            this.txtACTOR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtACTOR.Location = new System.Drawing.Point(240, 168);
            this.txtACTOR.Name = "txtACTOR";
            this.txtACTOR.Size = new System.Drawing.Size(392, 80);
            this.txtACTOR.TabIndex = 3;
            this.txtACTOR.Text = "주연배우";
            // 
            // txtDRECTOR
            // 
            this.txtDRECTOR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDRECTOR.Location = new System.Drawing.Point(240, 128);
            this.txtDRECTOR.Name = "txtDRECTOR";
            this.txtDRECTOR.Size = new System.Drawing.Size(392, 24);
            this.txtDRECTOR.TabIndex = 4;
            this.txtDRECTOR.Text = "감독";
            this.txtDRECTOR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(552, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "뒤로가기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(243, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "예매하기";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 543);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDRECTOR);
            this.Controls.Add(this.txtACTOR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTITLE);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "info";
            this.Text = "info";
            this.Load += new System.EventHandler(this.info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtTITLE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtACTOR;
        private System.Windows.Forms.Label txtDRECTOR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}