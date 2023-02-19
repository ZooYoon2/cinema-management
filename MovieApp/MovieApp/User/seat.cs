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

namespace MovieApp.User
{
    public partial class seat : Form
    {
        public string movie_no = "";
        public string theater_no = "";
        public string date = "";
        public string price = "";
        Dictionary<string,string> seat_number = new Dictionary<string,string>();
        List<string> select_seat = new List<string>();
        main OW;
        public seat()
        {
            InitializeComponent();
        }
        public Font AutoFontSize(Button bt, String text)
        {
            Font ft;
            Graphics gp;
            SizeF sz;
            Single Faktor, FaktorX, FaktorY;
            gp = bt.CreateGraphics();
            sz = gp.MeasureString(text, bt.Font);
            gp.Dispose();

            FaktorX = (bt.Width) / sz.Width;
            FaktorY = (bt.Height) / sz.Height;
            if (FaktorX > FaktorY)
                Faktor = FaktorY;
            else
                Faktor = FaktorX;
            ft = bt.Font;

            if (Faktor > 0)
                return new Font(ft.Name, ft.SizeInPoints * (Faktor));
            else
                return new Font(ft.Name, ft.SizeInPoints * (0.1f));
        }
        private void seat_draw()
        {
            try
            {
                OW.userconn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OW.userconn;
                cmd.CommandText = "select count(DISTINCT 행번호) from 상영관좌석 where 상영관번호 = " + theater_no;
                int row = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Parameters.Clear();
                cmd.CommandText = "select count(*) from 상영관좌석 where 상영관번호 = " + theater_no + "and 위치번호 like '1-%' group by 행번호";
                int each_group = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Parameters.Clear();
                cmd.CommandText = "select count(*) from 상영관좌석 where 상영관번호 = " + theater_no + "group by 행번호";
                int groups = Convert.ToInt32(cmd.ExecuteScalar()) / each_group;
                cmd.Parameters.Clear();
                tableLayoutPanel_seat.Controls.Clear();
                tableLayoutPanel_seat.RowStyles.Clear();
                tableLayoutPanel_seat.ColumnStyles.Clear();

                //tableLayoutPanel_seat.Anchor = (AnchorStyles.Top);
                //seattable.Dock = DockStyle.Fill;

                int colunm = (each_group * groups) + (groups - 1);

                int square = 0;
                if (row > colunm) { square = row; }
                else { square = colunm; }
                int H = (panel_seat.Height - 80 - 10) / square;
                int W = (panel_seat.Width - 20) / square;
                tableLayoutPanel_seat.Width = W * square;
                tableLayoutPanel_seat.Height = H * square;
                tableLayoutPanel_seat.ColumnCount = square;
                tableLayoutPanel_seat.RowCount = square;
                tableLayoutPanel_seat.Location = new Point((panel_seat.Width - (W * square)) / 2, 80);

                for (int i = 0; i < square; i++) { tableLayoutPanel_seat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40)); }
                for (int i = 0; i < square; i++) { tableLayoutPanel_seat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, W)); }

                for (int r = 0; r < row; r++)
                {
                    int count = 0;
                    int groupnum = 1;
                    for (int c = 0; c < colunm; c++)
                    {
                        if (count != each_group) {
                            Button seat = new Button();
                            seat.Name = string.Format("{0}_{1}-{2}", (char)('A' + r), groupnum, count + 1);
                            seat.Dock = DockStyle.Fill;
                            seat.Margin = new Padding(1, 1, 1, 1);
                            seat.Anchor = (AnchorStyles.Top|AnchorStyles.Left);
                            seat.TextAlign = ContentAlignment.MiddleCenter;
                            seat.Click += seat_Click;

                            string seattext = string.Format("{0}\n{1}-{2}", (char)('A' + r), groupnum, count + 1);
                            cmd.CommandText = string.Format("select count(*) from 예매좌석 where 상영관번호 = '{0}' and 영화번호 = {1} "
                                + "and TO_CHAR(상영시간,'yyyy-MM-dd HH24:MI') = '{2}' and 행번호 = '{3}' and 위치번호 = '{4}'",
                                    theater_no, movie_no, date, (char)('A' + r), groupnum + "-" + (count + 1));

                            if (Convert.ToInt32(cmd.ExecuteScalar()) != 0){ seat.Enabled = false; seat.Text = "X"; }
                            else { seat.Text = seattext; }
                            seat.Font = AutoFontSize(seat, seattext);
                            cmd.Parameters.Clear();
                            tableLayoutPanel_seat.Controls.Add(seat, c, r);
                            count++;
                        }
                        else { count = 0; groupnum++; }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex.Message);
            }
            finally
            {
                OW.userconn.Close();
            }
        }
        private void seat_Load(object sender, EventArgs e)
        {
            OW = (main)this.Owner;
            button_buy.Enabled = false;
            seat_draw();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OW.backForm();
        }
        private void seat_Click(object sender, EventArgs e)
        {
            Button lst = sender as Button;
            if (select_seat.Find(x=>x==lst.Name) != null)
            {
                lst.ForeColor = Color.Black;
                lst.BackColor = Color.Transparent;
                select_seat.Remove(lst.Name);
                if (select_seat.Count == 0){button_buy.Enabled = false;}
            }
            else
            {
                lst.ForeColor = Color.White;
                lst.BackColor = Color.DarkGray;
                select_seat.Add(lst.Name);
                button_buy.Enabled = true;
            }
        }

        private void button_buy_Click(object sender, EventArgs e)
        {
            buy buypage = new buy();
            buypage.movie_no = movie_no;
            buypage.theater_no = theater_no;
            buypage.date = date;
            buypage.price = price;
            buypage.select_seat = select_seat;
            OW.putForm(buypage, true);
        }
    }
}
