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
    public partial class buy : Form
    {
        public string movie_no = "";
        public string theater_no = "";
        public string date = "";
        public string price = "";
        public List<string> select_seat;
        main OW;
        public buy()
        {
            InitializeComponent();
        }
        private void page_draw()
        {
            try
            {
                OW.userconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OW.userconn;

                cmd.CommandText = string.Format("select 할인율 from 할인율 where 등급 in (select 등급 from 회원 where 회원번호 = {0})",OW.USERCD);
                int sale = Int32.Parse(cmd.ExecuteScalar().ToString());
                int start = Int32.Parse(price);
                float s = 1 - (float)sale / 100;
                int end = (int)(start * s);
                int count_ticket = select_seat.Count();

                label_price.Text = string.Format("총 {0}원 할인율 {1}% 적용 최종금액 : {2}원", start* count_ticket, sale, end * count_ticket);

                
                TableLayoutPanel bills = new TableLayoutPanel();
                bills.Height = 160 * count_ticket;
                bills.Width = 520;
                bills.Location = new Point(16, 8);
                bills.Anchor = AnchorStyles.Top;
                bills.Dock = DockStyle.Top;
                bills.ColumnCount = 1;
                bills.RowCount = count_ticket;
                bills.Font = new Font("나눔고딕", 10, FontStyle.Bold);
                panel2.Controls.Add(bills);

                for (int i = 0; i < count_ticket; i++)
                {
                    bills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160));
                }
                
                for (int i = 0; i < count_ticket; i++)
                {
                    Panel bill = new Panel();
                    bill.Paint += Panels_Paint;
                    bill.Size = new Size(480, 160);
                    bill.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

                    PictureBox movie_img = new PictureBox();
                    movie_img.Location = new Point(14, 6);
                    movie_img.Size = new Size(112, 140);
                    bill.Controls.Add(movie_img);
                    cmd.CommandText = string.Format("select 영화제목, 포스터 from 영화 where 영화번호 = {0}", movie_no);

                    OleDbDataReader read = cmd.ExecuteReader();
                    read.Read();
                    if (read.IsDBNull(1) == false)  //이미지가 없으면
                    {
                        Image image = ByteArrayToImage((byte[])read.GetValue(1));
                        Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                        image.GetThumbnailImage(112, 144, callback, new IntPtr()); //썸네일 만들기
                        movie_img.Image = image;
                        movie_img.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    Label title_s = new Label();
                    bill.Controls.Add(title_s);
                    title_s.Text = "영화";
                    title_s.AutoSize = true;
                    title_s.Location = new Point(160, 16);
                    Label title_e = new Label();
                    bill.Controls.Add(title_e);
                    title_e.Text = read.GetValue(0).ToString();
                    title_e.Text = movie_no;
                    title_e.Location = new Point(208, 16);
                    read.Close();
                    cmd.Parameters.Clear();

                    Label theater_s = new Label();
                    bill.Controls.Add(theater_s);
                    theater_s.Text = "상영관";
                    theater_s.AutoSize = true;
                    theater_s.Location = new Point(152, 44);
                    Label theater_e = new Label();
                    bill.Controls.Add(theater_e);
                    theater_e.AutoSize = true;
                    theater_e.Text = string.Format("{0}관", theater_no);
                    theater_e.Location = new Point(208, 44);

                    Label time_s = new Label();
                    bill.Controls.Add(time_s);
                    time_s.Text = "상영시간";
                    time_s.AutoSize = true;
                    time_s.Location = new Point(144, 70);
                    Label time_e = new Label();
                    bill.Controls.Add(time_e);
                    time_e.AutoSize = true;
                    time_e.Text = date;
                    time_e.Location = new Point(208, 70);

                    Label seat_s = new Label();
                    bill.Controls.Add(seat_s);
                    seat_s.Text = "좌석";
                    seat_s.AutoSize = true;
                    seat_s.Location = new Point(160, 99);
                    Label seat_e = new Label();
                    bill.Controls.Add(seat_e);
                    var splitseat = select_seat[i].Split('_');
                    seat_e.Text = string.Format("{0}-{1}", splitseat[0], splitseat[1]);
                    seat_e.AutoSize = true;
                    seat_e.Location = new Point(208, 99);

                    Label price_s = new Label();
                    bill.Controls.Add(price_s);
                    price_s.Text = "가격";
                    price_s.AutoSize = true;
                    price_s.Location = new Point(160, 126);
                    Label price_e = new Label();
                    bill.Controls.Add(price_e);
                    price_e.AutoSize = true;
                    price_e.Text = string.Format("{0}원", price);
                    price_e.Location = new Point(208, 126);

                    bills.Controls.Add(bill, 0, i);
                }
                OW.userconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
        }
        private void buy_Load(object sender, EventArgs e)
        {
            OW = (main)this.Owner;
            page_draw();
        }
        private byte[] imageToByteArray(Image img)
        {
            ImageConverter imageConverter = new ImageConverter();
            byte[] b = (byte[])imageConverter.ConvertTo(img, typeof(byte[]));
            return b;
        }
        private Image ByteArrayToImage(byte[] bytes)
        {
            ImageConverter imageConverter = new ImageConverter();
            Image img = (Image)imageConverter.ConvertFrom(bytes);
            return img;
        }

        public bool ThumbnailCallback()
        {
            return true;
        }

        private void Panels_Paint(object sender, PaintEventArgs e)
        {
            Panel lst = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, lst.ClientRectangle,
                Color.Black, 2, ButtonBorderStyle.Solid,
                Color.Black, 2, ButtonBorderStyle.Solid,
                Color.Black, 2, ButtonBorderStyle.Solid,
                Color.Black, 2, ButtonBorderStyle.Solid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OW.userconn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OW.userconn;
                foreach (var seat in select_seat)
                {
                    var num = seat.Split('_');
                    cmd.CommandText = String.Format("INSERT INTO 예매좌석 VALUES({0},TO_DATE('{1}','yyyy-MM-dd HH24:MI'),'{2}','{3}','{4}',{5},TO_DATE('{6}','yyyy-MM-dd HH24:MI'),'{7}')",
                    movie_no, date, theater_no, num[0], num[1], OW.USERCD, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), price);
                    cmd.ExecuteNonQuery();
                }
                OW.userconn.Close();
                OW.putForm(new OK());
                OW.deleteForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OW.backForm();
        }
    }
}
