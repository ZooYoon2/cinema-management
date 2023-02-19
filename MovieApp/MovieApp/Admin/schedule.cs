using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MovieApp.Admin
{
    public partial class schedule : Form
    {
        admin OW;
        DateTime select_date;
        Dictionary<DateTime,List<string>> in_schedule = new Dictionary<DateTime, List<string>>() ;
        public schedule()
        {
            InitializeComponent();
            
        }
        private void schedule_Load(object sender, EventArgs e)
        {
            OW = (admin)this.Owner;
            OW.update_theater(listView_theater);
            dateTimePicker1.Value = DateTime.Now;
        }
        private void listView_theater_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lst = sender as ListView;
            try
            {
                if (lst.SelectedItems != null)
                {
                    ListView.SelectedListViewItemCollection items = lst.SelectedItems;
                    ListViewItem item = items[0];
                    textBox_no.Text = item.SubItems[1].Text;
                    textBox_type.Text = item.SubItems[2].Text;
                    textBox_seat.Text = item.SubItems[3].Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
            }
        }
        private void update_schedule()
        {
            try
            {
                OW.conn.Open();
                //OW.conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = OW.conn;
                cmd.CommandText = "select 영화번호, 상영시간, 요금 from 상영스케줄 where 상영관번호 = '" + textBox_no.Text + "' and TO_CHAR(상영시간,'yyyy-MM-dd HH24:MI') >= '" +
                    select_date.ToString("yyyy-MM-dd HH:mm") + "' and TO_CHAR(상영시간,'yyyy-MM-dd HH24:MI') <= '" + (select_date.AddHours(18)).ToString("yyyy-MM-dd HH:mm") + "'"; //member 테이블
                OleDbDataReader read = cmd.ExecuteReader(); //select * from emp 결과
                in_schedule.Clear();
                while (read.Read())
                {
                    string no = read.GetValue(0).ToString();
                    DateTime I1 = read.GetDateTime(1);
                    string price = read.GetValue(2).ToString();//상영관번호
                    var I2 = new List<string>();
                    I2.Add(no);
                    I2.Add(price);
                    in_schedule.Add(I1, I2);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (OW.conn != null)
                {
                    OW.conn.Close(); //데이터베이스 연결 해제
                }
            }
        }
        private void timetable_draw()
        {
            tableLayoutPanel_schedule.Controls.Clear();
            tableLayoutPanel_schedule.RowStyles.Clear();
            tableLayoutPanel_schedule.ColumnStyles.Clear();

            tableLayoutPanel_schedule.Padding = new Padding(3, 3, 3, 3);

            tableLayoutPanel_schedule.ColumnCount = 8;
            tableLayoutPanel_schedule.RowCount = 30;
            int W = (tableLayoutPanel_schedule.Width-6) / 8;
            int H = (tableLayoutPanel_schedule.Height-6) / 30;
            for (int i = 0; i < 8; i++) { tableLayoutPanel_schedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, W)); }
            for (int i = 0; i < 30; i++) { tableLayoutPanel_schedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, H)); }
            
            List<DateTime> timeset = new List<DateTime>();
            for (DateTime loop_date = select_date; DateTime.Compare(loop_date, select_date.AddHours(19)) < 0; loop_date = loop_date.AddMinutes(10))
            {
                timeset.Add(loop_date);
            }

            DateTime ft = new DateTime(1990, 1, 1, 00, 00, 00);
            int row_index = 0;
            int colunm_index = 0;
            int numlock = -1;
            bool locking = false;
            int Remainder = 0;
            string title = "";
            string D="", T="", M="";
            foreach (DateTime time in timeset)
            {
                if (DateTime.Compare(Convert.ToDateTime(ft.ToString("yy-MM-dd")), Convert.ToDateTime(time.ToString("yy-MM-dd"))) == -1){//날짜변동시
                    ft = time;
                    Label DATE = new Label();
                    DATE.Text = time.ToString("yyyy-MM-dd");
                    DATE.Dock = DockStyle.Fill;
                    //DATE.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                    DATE.Margin = new Padding(1, 1, 1, 1);
                    DATE.TextAlign = ContentAlignment.MiddleCenter;
                    tableLayoutPanel_schedule.Controls.Add(DATE, colunm_index, row_index);
                    tableLayoutPanel_schedule.SetColumnSpan(DATE, 2);
                    tableLayoutPanel_schedule.SetRowSpan(DATE, 3);
                    row_index += 3;
                }
                Label KEY = new Label();
                KEY.Text = time.ToString("HH-mm");
                KEY.Dock = DockStyle.Fill;
                KEY.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top);
                KEY.Margin = new Padding(1, 1, 1, 1);
                KEY.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel_schedule.Controls.Add(KEY, colunm_index, row_index);
                if (numlock <= 0)
                {
                    Button VALUES = new Button();
                    VALUES.Text = "";
                    VALUES.Dock = DockStyle.Fill;
                    VALUES.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top);
                    VALUES.Margin = new Padding(1, 1, 1, 1);
                    VALUES.TextAlign = ContentAlignment.MiddleCenter;
                    VALUES.Click += VALUES_Click;
                    tableLayoutPanel_schedule.Controls.Add(VALUES, colunm_index + 1, row_index);
                    VALUES.Name = "addButton_" + time.ToString("yyyy-MM-dd HH:mm_") + textBox_no.Text;
                    if (!locking)
                    {
                        foreach (KeyValuePair<DateTime, List<String>> SC in in_schedule)
                        {
                            List<List<string>> movie_select = OW.find_movie("영화제목", " where 영화번호 = " + SC.Value[0]);
                            if (movie_select.Count != 0) { title = movie_select[0][0]; }
                            if (DateTime.Compare(SC.Key, time) == 0)
                            {
                                if (9 + row_index > 29)
                                {
                                    int gap = 29 - row_index;
                                    D = time.ToString("yyyy-MM-dd HH:mm");
                                    T = textBox_no.Text;
                                    M = SC.Value[0];
                                    if (gap != 0)
                                    {
                                        VALUES.Text = title;
                                        tableLayoutPanel_schedule.SetRowSpan(VALUES, gap+1);
                                        VALUES.Name = "deleteButton_" + D + "_" + T + "_" + M;
                                    }
                                    Remainder = 8 - gap;
                                    numlock = gap;
                                    locking = true;
                                }
                                else {
                                    VALUES.Text = title;
                                    tableLayoutPanel_schedule.SetRowSpan(VALUES, 9); numlock = 8;
                                    VALUES.Name = "deleteButton_" + time.ToString("yyyy-MM-dd HH:mm_") + textBox_no.Text +"_"+SC.Value[0];
                                }
                            }
                        }
                    }
                    else
                    {
                        VALUES.Text = title;
                        tableLayoutPanel_schedule.SetRowSpan(VALUES, Remainder); numlock = Remainder-1; locking = false;
                        VALUES.Name = "deleteButton_" + D + "_" + T + "_" + M;
                    }
                }
                else { numlock -= 1; }
                row_index++;
                if (row_index == 30) { row_index = 0; colunm_index += 2; }//세로로 기록 가로이동
            }
        }
        public void refrash() { update_schedule();timetable_draw(); }
        private void VALUES_Click(object sender, EventArgs e)
        {
            Button lst = sender as Button;
            string[] info = lst.Name.Split('_');
            if (info[0] == "addButton")
            {
                Admin.addschedule add = new Admin.addschedule();
                add.Owner = this;
                add.date_s = info[1];
                add.theater = info[2];
                add.ShowDialog();
            }
            else if(info[0] == "deleteButton"){
                Admin.deleteschedule delete = new Admin.deleteschedule();
                delete.Owner = this;
                delete.date_s = info[1];
                delete.theater = info[2];
                delete.movie = info[3];
                delete.ShowDialog();
            }
            else
            {
                MessageBox.Show("오류");
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_no.Text=="")
            {
                MessageBox.Show("상영관을 선택해주세요.");
            }
            else
            {
                update_schedule();
                timetable_draw();
            }
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker lst = sender as DateTimePicker;
            select_date = new DateTime(lst.Value.Year,lst.Value.Month,lst.Value.Day,7,00,00);
        }
        private void tableLayoutPanel_schedule_Paint(object sender, PaintEventArgs e)
        {
            Panel lst = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, lst.ClientRectangle,
                Color.Black, 2, ButtonBorderStyle.Solid,
                Color.Black, 2, ButtonBorderStyle.Solid,
                Color.Black, 2, ButtonBorderStyle.Solid,
                Color.Black, 2, ButtonBorderStyle.Solid);
        }
    }
}
