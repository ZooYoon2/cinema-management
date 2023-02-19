using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace MovieApp.User
{
    public partial class ticket : Form
    {
        private Button timeButton;
        private Button dateButton;
        private Button movieButton;
        main OW;
        public string select_movie_no = "";
        string select_date = "";
        string select_time = "";
        string select_theater_no = "";
        string select_teather_type = "";
        string price = "";
        List<TimeTableItem> Q = new List<TimeTableItem>();
        TableLayoutPanel A = new TableLayoutPanel();
        public ticket()
        {
            InitializeComponent();
        }
        //영화+날짜에 대한 시간표틀
        public class TimeTableItem
        {
            public TimeTableItem(string theater, string theater_type, Dictionary<string, string> time_price)
            {
                Theater = theater;
                Theater_type = theater_type;
                Time = time_price;
            }
            public string Theater { get; set; }
            public string Theater_type { get; set; }
            public Dictionary<string, string> Time { get; set; }
            public string Price { get; set; }
        }

        //영화
        private void movie_DrawItem()
        {
            
            try
            {
                TableLayoutPanel A = new TableLayoutPanel();
                Size block_size = new Size(160, 25);
                panel_movie.Controls.Add(A);
                A.Padding = new Padding(0, 0, 0, 0);
                A.Margin = new Padding(0, 0, 0, 0);
                A.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                A.ColumnCount = 1;
                int movie_amount = 20;
                A.RowCount = movie_amount;
                A.Size = new Size(196, movie_amount * 25);
                A.AutoSize = true;
                List<List<string>> movie = OW.find_movie("영화제목, 영화번호");
                foreach (List<string> title in movie)
                {
                    Button set = new Button();
                    set.Anchor = AnchorStyles.None;
                    set.Dock = DockStyle.Fill;
                    set.Text = title[0];
                    set.Name = "button_"+title[1];
                    set.Font = new Font(Font.FontFamily, 10);
                    set.Size = block_size;
                    set.FlatStyle = FlatStyle.Flat;
                    set.FlatAppearance.BorderSize = 0;
                    set.BackColor = Color.Transparent;
                    set.Click += movie_Click;
                    if (select_movie_no == title[1]) { set.PerformClick();label_movietitle.Text = title[0]; }
                    A.Controls.Add(set);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                
            }
            
        }
        private void movie_Click(object sender, EventArgs e)
        {
            Button lst = sender as Button;
            if (movieButton != null)
            {
                movieButton.ForeColor = Color.Black;
                movieButton.BackColor = Color.Transparent;
            }
            movieButton = lst;
            lst.ForeColor = Color.White;
            lst.BackColor = Color.DarkGray;
            select_movie_no = lst.Name.Split('_')[1];
            label_movietitle.Text = lst.Text;
            timetable_reset();
            put_schedule();
        }

        private bool ThumbnailCallback()
        {
            throw new NotImplementedException();
        }

        private Image ByteArrayToImage(byte[] xbytes)
        {
            throw new NotImplementedException();
        }

        //날짜
        private void date_DrawItem()
        {
            TableLayoutPanel A = new TableLayoutPanel();
            Size block_size = new Size(10, 25);
            panel_date.Controls.Add(A);
            A.Padding = new Padding(0, 0, 0, 0);
            A.Margin = new Padding(0, 0, 0, 0);
            A.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            A.ColumnCount = 1;

            A.RowCount = 20;
            A.Size = new Size(70, 20 * 25);
            A.AutoSize = true;

            Label YEAR = new Label();
            YEAR.Text = DateTime.Now.ToString("yyyy");
            YEAR.Size = block_size;
            YEAR.Dock = DockStyle.Fill;
            YEAR.TextAlign = ContentAlignment.MiddleCenter;
            A.Controls.Add(YEAR);
            Label MONTH = new Label();
            MONTH.Text = DateTime.Now.ToString("MMMM");
            MONTH.Size = block_size;
            MONTH.Dock = DockStyle.Fill;
            MONTH.TextAlign = ContentAlignment.MiddleCenter;
            A.Controls.Add(MONTH);
            
            for (var date = DateTime.Now;DateTime.Compare(date,DateTime.Now.AddDays(14))<0;date=date.AddDays(1))
            {
                if ((date.ToString("MM") != DateTime.Now.ToString("MM")) && (date.ToString("dd")=="01"))
                {
                    Label NYEAR = new Label();
                    NYEAR.Text = date.ToString("yyyy");
                    NYEAR.Size = block_size;
                    NYEAR.Dock = DockStyle.Fill;
                    NYEAR.TextAlign = ContentAlignment.MiddleCenter;
                    A.Controls.Add(NYEAR);
                    Label NMONTH = new Label();
                    NMONTH.Text = date.ToString("MMMM");
                    NMONTH.Size = block_size;
                    NMONTH.Dock = DockStyle.Fill;
                    NMONTH.TextAlign = ContentAlignment.MiddleCenter;
                    A.Controls.Add(NMONTH);
                }
                Button set = new Button();
                set.Anchor = AnchorStyles.None;
                set.Dock = DockStyle.Fill;
                set.Text = date.ToString("ddd dd");
                set.Name = date.ToString("yyyy-MM-dd");
                set.Font = new Font(Font.FontFamily, 10);
                set.Size = block_size;
                set.FlatStyle = FlatStyle.Flat;
                set.FlatAppearance.BorderSize = 0;
                set.BackColor = Color.Transparent;
                set.Click += new EventHandler(date_Click);
                A.Controls.Add(set);
            }
        }
        private void date_Click(object sender, EventArgs e)
        {
            Button lst = sender as Button;
            if (dateButton != null)
            {
                dateButton.ForeColor = Color.Black;
                dateButton.BackColor = Color.Transparent;
            }
            dateButton = lst;
            lst.ForeColor = Color.White;
            lst.BackColor = Color.DarkGray;
            select_date = lst.Name;
            label_date.Text = lst.Name;
            timetable_reset();
            put_schedule();
        }
        private void put_schedule()
        {
            if (select_movie_no != "" && select_date != "")
            {
                List<List<string>> select_theaters = OW.find_theater("상영관번호, 상영관형태");
                List<List<string>> select_schedule = new List<List<string>>();
                Q.Clear();
                foreach (List<string> theater in select_theaters)
                {
                    select_schedule = OW.find_schedule("TO_CHAR(상영시간,'HH24:MI'), 요금", "where 상영관번호 = '" + theater[0] + "' and 영화번호 = " +
                        Int32.Parse(select_movie_no) + " and TO_CHAR(상영시간,'yyyy-MM-dd') = '" + select_date + "'");
                    Dictionary<string,string> scd = new Dictionary<string, string>();
                    if (select_schedule.Count != 0)
                    {
                        foreach (List<string> date_schedule in select_schedule)
                        {
                            scd.Add(date_schedule[0], date_schedule[1]);
                        }
                        if (scd.Count != 0)
                        {
                            Q.Add(new TimeTableItem(theater[0], theater[1], scd));
                        }
                    }
                }
                timetable_DrawItem(Q);
            }
        }
        //시간표
        private void timetable_DrawItem(List <TimeTableItem> data)
        {
            A.Controls.Clear();
            A.ColumnStyles.Clear();
            A.RowStyles.Clear();
            Size block_size = new Size(53, 25);
            panel_timetable.Controls.Add(A);
            A.Padding = new Padding(0, 0, 0, 0);
            A.Margin = new Padding(0, 0, 0, 0);
            A.Anchor = (AnchorStyles.Left| AnchorStyles.Top);
            A.ColumnCount = 1;
            A.RowCount = data.Count;
            if (data.Count != 0)
            {
                A.ColumnCount = 6;
                int rowCount = 0;
                foreach (var timetable in data)
                {
                    rowCount++;
                    int Count = timetable.Time.Count;
                    if (Count % 3 == 0) { rowCount += (Count / 3); }
                    else { rowCount += (Count / 3) + 1; }
                }
                A.RowCount = rowCount;
                A.Size = new Size(365, rowCount * 25);
                A.AutoSize = true;
                foreach (var timetable in data)
                {
                    Label theater = new Label();
                    theater.Text = timetable.Theater + "관 " + timetable.Theater_type;
                    theater.Size = block_size;
                    theater.Dock = DockStyle.Fill;
                    //theater.Anchor = AnchorStyles.None;
                    theater.TextAlign = ContentAlignment.MiddleLeft;
                    A.Controls.Add(theater);
                    A.SetColumnSpan(theater, 6);

                    OW.userconn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = OW.userconn;
                    foreach (KeyValuePair<string,string> table in timetable.Time)
                    {
                        Button set = new Button();
                        set.Anchor = AnchorStyles.None;
                        set.Dock = DockStyle.Fill;
                        set.Text = table.Key;
                        set.Name = "button_" + timetable.Theater + "_" + timetable.Theater_type + "_" + table.Value;
                        set.Size = block_size;
                        set.BackColor = Color.Transparent;
                        set.Click += new EventHandler(timetable_Click);
                        A.Controls.Add(set);
                        Label seats = new Label();
                        seats.Anchor = AnchorStyles.None;
                        seats.Dock = DockStyle.Fill;
                        cmd.CommandText = string.Format("select count(*) from (select 행번호, 위치번호 From 상영관좌석 where 상영관번호 = '{0}' MINUS select 행번호, 위치번호 From 예매좌석 where 상영관번호 = '{0}' and 영화번호 = {1} and TO_CHAR(상영시간,'yyyy-MM-dd HH24:MI') = '{2}')"
                            , timetable.Theater, select_movie_no, (select_date+" "+table.Key));
                        seats.Text = String.Format("{0}좌석", Convert.ToInt32(cmd.ExecuteScalar()));
                        cmd.Parameters.Clear();
                        seats.Size = block_size;
                        seats.TextAlign = ContentAlignment.MiddleLeft;
                        A.Controls.Add(seats);
                    }
                    OW.userconn.Close();
                }
            }
            else {
                A.ColumnCount = 1;
                A.RowCount = 1;
                A.Size = new Size(365, 272);
                Label empty = new Label();
                empty.Text = "일정이 없습니다";
                empty.Dock = DockStyle.Fill;
                empty.Anchor = (AnchorStyles.Top|AnchorStyles.Left);
                empty.TextAlign = ContentAlignment.MiddleCenter;
                A.Controls.Add(empty);
            }
        }
        private void timetable_Click(object sender, EventArgs e)
        {
            Button lst = sender as Button;
            if(timeButton != null)
            {
                timeButton.ForeColor = Color.Black;
                timeButton.BackColor = Color.Transparent;
            }
            lst.ForeColor = Color.White;
            lst.BackColor = Color.DarkGray;
            timeButton = lst;
            select_time = lst.Text;
            label_time.Text = select_time;
            var lstName = lst.Name.Split('_');
            select_theater_no = lstName[1];
            select_teather_type = lstName[2];
            price = lstName[3];
            label_theaterno.Text = select_theater_no + "관";
            label_theatertype.Text = select_teather_type;
            button_ticket.Enabled = true;
        }
        private void timetable_reset()
        {
            select_theater_no = "";
            select_teather_type = "";
            label_theaterno.Text = "";
            label_theatertype.Text = "";
            label_time.Text = "";
            button_ticket.Enabled = false;
        }
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Rectangle r = e.CellBounds;
            Pen pen = new Pen(Color.White, 2);
            e.Graphics.DrawLine(pen, r.X, r.Y, r.X, r.Y + r.Height);
            int cx = e.Column == tableLayoutPanel1.ColumnCount - 1 ? -1 : 0;
            if (cx != 0) e.Graphics.DrawLine(pen, r.X + r.Width + cx, r.Y, r.X + r.Width + cx, r.Y + r.Height);
        }
        private void ticket_Load(object sender, EventArgs e)
        {
            OW = (main)this.Owner;
            label_movietitle.Text = "";
            label_date.Text = "";
            label_time.Text = "";
            label_theaterno.Text = "";
            label_theatertype.Text = "";
            date_DrawItem();
            movie_DrawItem();
            button_ticket.Enabled = false;
        }
        private void button_ticket_Click(object sender, EventArgs e)
        {
            if (OW.b_USER)
            {
                seat nextform = new User.seat();
                nextform.movie_no = select_movie_no;
                nextform.theater_no = select_theater_no;
                nextform.date = select_date + " " + select_time;
                nextform.price = price;
                OW.putForm(nextform, true);
            }
            else
            {
                MessageBox.Show("로그인 후 사용해주세요");
                OW.putForm(new signin(),true);
            }
        }
    }
}
