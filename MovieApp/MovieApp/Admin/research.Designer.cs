
namespace MovieApp.Admin
{
    partial class research
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
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancle = new System.Windows.Forms.Button();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_director = new System.Windows.Forms.TextBox();
            this.textBox_actor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ok.Location = new System.Drawing.Point(18, 140);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(67, 31);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "확인";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancle
            // 
            this.button_cancle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_cancle.Location = new System.Drawing.Point(96, 140);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(67, 31);
            this.button_cancle.TabIndex = 1;
            this.button_cancle.Text = "취소";
            this.button_cancle.UseVisualStyleBackColor = true;
            this.button_cancle.Click += new System.EventHandler(this.button_cancle_Click);
            // 
            // textBox_title
            // 
            this.textBox_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_title.Location = new System.Drawing.Point(64, 44);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(100, 21);
            this.textBox_title.TabIndex = 2;
            // 
            // textBox_director
            // 
            this.textBox_director.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_director.Location = new System.Drawing.Point(64, 76);
            this.textBox_director.Name = "textBox_director";
            this.textBox_director.Size = new System.Drawing.Size(100, 21);
            this.textBox_director.TabIndex = 3;
            // 
            // textBox_actor
            // 
            this.textBox_actor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_actor.Location = new System.Drawing.Point(64, 108);
            this.textBox_actor.Name = "textBox_actor";
            this.textBox_actor.Size = new System.Drawing.Size(100, 21);
            this.textBox_actor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(56, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "검색";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "제목";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "감독";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(16, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "배우";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button_ok);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_cancle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_title);
            this.panel1.Controls.Add(this.textBox_director);
            this.panel1.Controls.Add(this.textBox_actor);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 176);
            this.panel1.TabIndex = 10;
            // 
            // research
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 194);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "research";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "research";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancle;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_director;
        private System.Windows.Forms.TextBox textBox_actor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}