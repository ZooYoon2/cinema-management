
namespace MovieApp.User
{
    partial class ticket
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_timetable = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_date = new System.Windows.Forms.Panel();
            this.panel_movie = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.button_ticket = new System.Windows.Forms.Button();
            this.label_movietitle = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_theatertype = new System.Windows.Forms.Label();
            this.label_theaterno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.panel_timetable, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_date, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel_movie, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(60, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 308);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.TabStop = true;
            this.tableLayoutPanel1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint);
            // 
            // panel_timetable
            // 
            this.panel_timetable.AutoScroll = true;
            this.panel_timetable.AutoSize = true;
            this.panel_timetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel_timetable.Location = new System.Drawing.Point(309, 33);
            this.panel_timetable.Name = "panel_timetable";
            this.panel_timetable.Size = new System.Drawing.Size(365, 272);
            this.panel_timetable.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(309, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "시간표";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "날짜";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "영화";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_date
            // 
            this.panel_date.AutoScroll = true;
            this.panel_date.BackColor = System.Drawing.Color.Transparent;
            this.panel_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_date.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_date.Location = new System.Drawing.Point(208, 33);
            this.panel_date.Name = "panel_date";
            this.panel_date.Size = new System.Drawing.Size(95, 272);
            this.panel_date.TabIndex = 6;
            // 
            // panel_movie
            // 
            this.panel_movie.AutoScroll = true;
            this.panel_movie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_movie.Location = new System.Drawing.Point(6, 33);
            this.panel_movie.Name = "panel_movie";
            this.panel_movie.Size = new System.Drawing.Size(196, 272);
            this.panel_movie.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(56, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "예매";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox_image);
            this.panel1.Controls.Add(this.button_ticket);
            this.panel1.Controls.Add(this.label_movietitle);
            this.panel1.Controls.Add(this.label_time);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_theatertype);
            this.panel1.Controls.Add(this.label_theaterno);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 112);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new System.Drawing.Point(160, 16);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(88, 88);
            this.pictureBox_image.TabIndex = 2;
            this.pictureBox_image.TabStop = false;
            // 
            // button_ticket
            // 
            this.button_ticket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_ticket.Enabled = false;
            this.button_ticket.Location = new System.Drawing.Point(648, 16);
            this.button_ticket.Name = "button_ticket";
            this.button_ticket.Size = new System.Drawing.Size(88, 72);
            this.button_ticket.TabIndex = 1;
            this.button_ticket.Text = "예매하기";
            this.button_ticket.UseVisualStyleBackColor = true;
            this.button_ticket.Click += new System.EventHandler(this.button_ticket_Click);
            // 
            // label_movietitle
            // 
            this.label_movietitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_movietitle.AutoSize = true;
            this.label_movietitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_movietitle.ForeColor = System.Drawing.Color.White;
            this.label_movietitle.Location = new System.Drawing.Point(96, 16);
            this.label_movietitle.Name = "label_movietitle";
            this.label_movietitle.Size = new System.Drawing.Size(55, 15);
            this.label_movietitle.TabIndex = 0;
            this.label_movietitle.Text = "영화제목";
            // 
            // label_time
            // 
            this.label_time.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(320, 32);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(55, 15);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "HH:MM";
            // 
            // label_date
            // 
            this.label_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(320, 16);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(93, 15);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "YYYY-MM-DD";
            // 
            // label_theatertype
            // 
            this.label_theatertype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_theatertype.AutoSize = true;
            this.label_theatertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_theatertype.ForeColor = System.Drawing.Color.White;
            this.label_theatertype.Location = new System.Drawing.Point(320, 72);
            this.label_theatertype.Name = "label_theatertype";
            this.label_theatertype.Size = new System.Drawing.Size(64, 15);
            this.label_theatertype.TabIndex = 0;
            this.label_theatertype.Text = "X-screen";
            // 
            // label_theaterno
            // 
            this.label_theaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_theaterno.AutoSize = true;
            this.label_theaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_theaterno.ForeColor = System.Drawing.Color.White;
            this.label_theaterno.Location = new System.Drawing.Point(320, 56);
            this.label_theaterno.Name = "label_theaterno";
            this.label_theaterno.Size = new System.Drawing.Size(15, 15);
            this.label_theaterno.TabIndex = 0;
            this.label_theaterno.Text = "1";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(64, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "영화";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(264, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "상영날짜";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(272, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "상영관";
            // 
            // ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ticket";
            this.Text = "ticket";
            this.Load += new System.EventHandler(this.ticket_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_timetable;
        private System.Windows.Forms.Panel panel_date;
        private System.Windows.Forms.Panel panel_movie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_theatertype;
        private System.Windows.Forms.Label label_theaterno;
        private System.Windows.Forms.Label label_movietitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_ticket;
        private System.Windows.Forms.PictureBox pictureBox_image;
    }
}