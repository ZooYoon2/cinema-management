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

namespace MovieApp.User
{
    public partial class info : Form
    {
        main OW;
        public string MOVIECD = "";
        public info()
        {
            InitializeComponent();
        }

        private void info_Load(object sender, EventArgs e)
        {
            OW = (main)this.Owner;
            try
            {
                OW.userconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OW.userconn;
                cmd.CommandText = "select 영화제목, 영화감독, 주연배우, 포스터 from 영화 where 영화번호 = "+MOVIECD;
                OleDbDataReader read = cmd.ExecuteReader();
                read.Read();
                txtTITLE.Text = string.Format("제목 : {0}", read.GetValue(0).ToString());
                txtDRECTOR.Text = string.Format("감독 : {0}", read.GetValue(1).ToString());
                txtACTOR.Text = string.Format("주연배우 : {0}", read.GetValue(2).ToString());
                Image image = ByteArrayToImage((byte[])read.GetValue(3));
                Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                image.GetThumbnailImage(208, 296, callback, new IntPtr()); //썸네일 만들기
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void button1_Click(object sender, EventArgs e)
        {
            OW.backForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button lst = sender as Button;
            ticket tik = new ticket();
            tik.select_movie_no = MOVIECD;
            OW.putForm(tik);
        }
    }
}
