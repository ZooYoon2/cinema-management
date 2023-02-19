
namespace MovieApp.Admin
{
    partial class movies
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_create = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.listView_movie = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_no = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_director = new System.Windows.Forms.TextBox();
            this.textBox_actor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_image = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.comboBox_option = new System.Windows.Forms.ComboBox();
            this.button_re = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(640, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 280);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(440, 368);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(56, 31);
            this.button_create.TabIndex = 2;
            this.button_create.Text = "추가";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(496, 368);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(56, 31);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(552, 368);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(56, 31);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "수정";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(440, 336);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(168, 32);
            this.button_reset.TabIndex = 5;
            this.button_reset.Text = "초기화";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // listView_movie
            // 
            this.listView_movie.HideSelection = false;
            this.listView_movie.Location = new System.Drawing.Point(24, 96);
            this.listView_movie.Name = "listView_movie";
            this.listView_movie.Size = new System.Drawing.Size(400, 552);
            this.listView_movie.TabIndex = 6;
            this.listView_movie.UseCompatibleStateImageBehavior = false;
            this.listView_movie.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_movie_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(440, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(440, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "제목";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(440, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "감독";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(432, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "주연배우";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_no
            // 
            this.textBox_no.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_no.Location = new System.Drawing.Point(504, 96);
            this.textBox_no.Name = "textBox_no";
            this.textBox_no.ReadOnly = true;
            this.textBox_no.Size = new System.Drawing.Size(32, 22);
            this.textBox_no.TabIndex = 11;
            this.textBox_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_title
            // 
            this.textBox_title.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_title.Location = new System.Drawing.Point(504, 128);
            this.textBox_title.MaxLength = 14;
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(120, 22);
            this.textBox_title.TabIndex = 12;
            // 
            // textBox_director
            // 
            this.textBox_director.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_director.Location = new System.Drawing.Point(504, 160);
            this.textBox_director.MaxLength = 9;
            this.textBox_director.Name = "textBox_director";
            this.textBox_director.Size = new System.Drawing.Size(120, 22);
            this.textBox_director.TabIndex = 13;
            // 
            // textBox_actor
            // 
            this.textBox_actor.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_actor.Location = new System.Drawing.Point(504, 192);
            this.textBox_actor.MaxLength = 50;
            this.textBox_actor.Multiline = true;
            this.textBox_actor.Name = "textBox_actor";
            this.textBox_actor.Size = new System.Drawing.Size(120, 56);
            this.textBox_actor.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(640, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "포스터";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_image
            // 
            this.button_image.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_image.Location = new System.Drawing.Point(760, 96);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(75, 23);
            this.button_image.TabIndex = 16;
            this.button_image.Text = "불러오기";
            this.button_image.UseVisualStyleBackColor = true;
            this.button_image.Click += new System.EventHandler(this.button_image_Click);
            // 
            // button_info
            // 
            this.button_info.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_info.Location = new System.Drawing.Point(544, 96);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(75, 23);
            this.button_info.TabIndex = 17;
            this.button_info.Text = "불러오기";
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // comboBox_option
            // 
            this.comboBox_option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_option.FormattingEnabled = true;
            this.comboBox_option.Items.AddRange(new object[] {
            "번호순(오름차순)",
            "번호순(내림차순)",
            "가나다순(오름차순)",
            "가나다순(내림차순)"});
            this.comboBox_option.Location = new System.Drawing.Point(24, 72);
            this.comboBox_option.Name = "comboBox_option";
            this.comboBox_option.Size = new System.Drawing.Size(121, 22);
            this.comboBox_option.TabIndex = 18;
            this.comboBox_option.SelectedIndexChanged += new System.EventHandler(this.comboBox_option_SelectedIndexChanged);
            // 
            // button_re
            // 
            this.button_re.Location = new System.Drawing.Point(376, 72);
            this.button_re.Name = "button_re";
            this.button_re.Size = new System.Drawing.Size(48, 23);
            this.button_re.TabIndex = 19;
            this.button_re.Text = "초기화";
            this.button_re.UseVisualStyleBackColor = true;
            this.button_re.Click += new System.EventHandler(this.button_re_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "검색하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(24, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "영화관리";
            // 
            // movies
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(860, 700);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_re);
            this.Controls.Add(this.comboBox_option);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.button_image);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_actor);
            this.Controls.Add(this.textBox_director);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.textBox_no);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_movie);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "movies";
            this.Text = "movies";
            this.Load += new System.EventHandler(this.movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.ListView listView_movie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_no;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_director;
        private System.Windows.Forms.TextBox textBox_actor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_image;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.ComboBox comboBox_option;
        private System.Windows.Forms.Button button_re;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}