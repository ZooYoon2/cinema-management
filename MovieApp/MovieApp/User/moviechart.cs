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
using System.Data.SqlClient;
using System.IO;

namespace MovieApp.User
{
    public partial class moviechart : Form
    {
        main OW;
        public moviechart()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button lst = sender as Button;
            info movieinfo = new info();
            movieinfo.MOVIECD = lst.Name.Split('_')[1];
            OW.putForm(movieinfo, true);
        }
        private void info_Load(object sender, EventArgs e)
        {
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
        private void moviechart_Load(object sender, EventArgs e)
        {
            OW = (main)this.Owner;
            try
            {
                OW.userconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OW.userconn;
                cmd.CommandText = "select count(*) from 영화";
                int row = Convert.ToInt32(cmd.ExecuteScalar());

                MOVIES.ColumnCount = 3;
                MOVIES.RowCount = row;
                MOVIES.AutoSize = true;

                cmd.CommandText = "select 영화번호, 영화제목, 포스터 from 영화 ";
                OleDbDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    string cd = read.GetValue(0).ToString();
                    string title = read.GetValue(1).ToString();
                    Image image = ByteArrayToImage((byte[])read.GetValue(2));
                    Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                    Image img = image.GetThumbnailImage(200, 280, callback, new IntPtr()); //썸네일 만들기
                    Panel lst = moviePanel(cd,title, img);
                    MOVIES.Controls.Add(lst);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                if (OW.userconn != null)
                {
                    OW.userconn.Close();
                }
            }
        }
        private Panel moviePanel(string cd,string title,Image image)
        {
            Panel A = new Panel();
            A.Anchor = System.Windows.Forms.AnchorStyles.Top;
            A.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            A.Location = new System.Drawing.Point(72, 96);
            A.Name = "panel2";
            A.Size = new System.Drawing.Size(216, 400);
            A.TabIndex = 6;

            Button ticketbt = new Button();
            ticketbt.BackColor = System.Drawing.Color.Tomato;
            ticketbt.FlatAppearance.BorderSize = 0;
            ticketbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ticketbt.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            ticketbt.ForeColor = System.Drawing.Color.White;
            ticketbt.Location = new System.Drawing.Point(112, 360);
            ticketbt.Name = "button_"+cd;
            ticketbt.Click += ticket_Click;
            ticketbt.Size = new System.Drawing.Size(91, 32);
            ticketbt.TabIndex = 4;
            ticketbt.Text = "예매하기";
            ticketbt.UseVisualStyleBackColor = false;

            Button poster = new Button();
            poster.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            poster.FlatAppearance.BorderSize = 5;
            poster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            poster.Location = new System.Drawing.Point(8, 40);
            poster.Name = "button_"+cd;
            poster.Size = new System.Drawing.Size(200, 280);
            poster.TabIndex = 4;
            poster.UseVisualStyleBackColor = true;
            poster.Image = image;
            poster.Click += new System.EventHandler(this.button1_Click);

            Label mname = new Label();
            mname.BackColor = System.Drawing.Color.Transparent;
            mname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            mname.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            mname.Location = new System.Drawing.Point(8, 328);
            mname.Name = "label3";
            mname.Size = new System.Drawing.Size(200, 24);
            mname.TabIndex = 1;
            mname.Text = title;
            mname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            A.Controls.Add(mname);
            A.Controls.Add(ticketbt);
            A.Controls.Add(poster);
            return A;
        }

        private void ticket_Click(object sender, EventArgs e)
        {
            Button lst = sender as Button;
            ticket tik = new ticket();
            tik.select_movie_no = lst.Name.Split('_')[1];
            OW.putForm(tik);
        }
    }
}
