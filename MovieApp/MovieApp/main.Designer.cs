
namespace MovieApp
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_user = new System.Windows.Forms.Panel();
            this.button_E = new System.Windows.Forms.Button();
            this.button_ticket = new System.Windows.Forms.Button();
            this.button_movies = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.mainscreen = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.panel_user);
            this.panel1.Controls.Add(this.button_E);
            this.panel1.Controls.Add(this.button_ticket);
            this.panel1.Controls.Add(this.button_movies);
            this.panel1.Controls.Add(this.button_home);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 90);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_user
            // 
            this.panel_user.Location = new System.Drawing.Point(760, 24);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(100, 50);
            this.panel_user.TabIndex = 0;
            // 
            // button_E
            // 
            this.button_E.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_E.BackColor = System.Drawing.Color.Transparent;
            this.button_E.FlatAppearance.BorderSize = 0;
            this.button_E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_E.Location = new System.Drawing.Point(762, 26);
            this.button_E.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.button_E.Name = "button_E";
            this.button_E.Size = new System.Drawing.Size(100, 50);
            this.button_E.TabIndex = 3;
            this.button_E.Text = "혜택";
            this.button_E.UseVisualStyleBackColor = false;
            // 
            // button_ticket
            // 
            this.button_ticket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_ticket.BackColor = System.Drawing.Color.Transparent;
            this.button_ticket.FlatAppearance.BorderSize = 0;
            this.button_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ticket.Location = new System.Drawing.Point(402, 26);
            this.button_ticket.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.button_ticket.Name = "button_ticket";
            this.button_ticket.Size = new System.Drawing.Size(100, 50);
            this.button_ticket.TabIndex = 2;
            this.button_ticket.Text = "예매";
            this.button_ticket.UseVisualStyleBackColor = false;
            this.button_ticket.Click += new System.EventHandler(this.B_ticket_Click);
            // 
            // button_movies
            // 
            this.button_movies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_movies.BackColor = System.Drawing.Color.Transparent;
            this.button_movies.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_movies.FlatAppearance.BorderSize = 0;
            this.button_movies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_movies.Location = new System.Drawing.Point(272, 26);
            this.button_movies.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.button_movies.Name = "button_movies";
            this.button_movies.Size = new System.Drawing.Size(100, 50);
            this.button_movies.TabIndex = 1;
            this.button_movies.Text = "영화";
            this.button_movies.UseVisualStyleBackColor = false;
            this.button_movies.Click += new System.EventHandler(this.B_movies_Click);
            // 
            // button_home
            // 
            this.button_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_home.BackColor = System.Drawing.Color.Transparent;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Location = new System.Drawing.Point(532, 26);
            this.button_home.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(200, 50);
            this.button_home.TabIndex = 0;
            this.button_home.Text = "HOME";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.B_home_Click);
            // 
            // mainscreen
            // 
            this.mainscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainscreen.AutoScroll = true;
            this.mainscreen.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.mainscreen.AutoScrollMinSize = new System.Drawing.Size(3, 3);
            this.mainscreen.AutoSize = true;
            this.mainscreen.BackColor = System.Drawing.Color.Transparent;
            this.mainscreen.ForeColor = System.Drawing.Color.Black;
            this.mainscreen.Location = new System.Drawing.Point(0, 88);
            this.mainscreen.MaximumSize = new System.Drawing.Size(1264, 960);
            this.mainscreen.MinimumSize = new System.Drawing.Size(400, 200);
            this.mainscreen.Name = "mainscreen";
            this.mainscreen.Padding = new System.Windows.Forms.Padding(3);
            this.mainscreen.Size = new System.Drawing.Size(1264, 755);
            this.mainscreen.TabIndex = 5;
            // 
            // main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 843);
            this.Controls.Add(this.mainscreen);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1280, 1680);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_ticket;
        private System.Windows.Forms.Button button_movies;
        private System.Windows.Forms.Panel mainscreen;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Button button_E;
    }
}

