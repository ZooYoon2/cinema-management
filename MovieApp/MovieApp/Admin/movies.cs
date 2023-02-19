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

namespace MovieApp.Admin
{
    public partial class movies : Form
    {
        Image image=null;
        admin OW;
        string opt_query = "";
        string search_query = "";
        public movies()
        {
            InitializeComponent();
            reset();
        }
        private void movies_Load(object sender, EventArgs e)
        {
            OW = (admin)this.Owner;
            OW.update_movie(listView_movie);
            if (image == null)
            {
                pictureBox1.Image = image;
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
        public bool ThumbnailCallback(){
            return true;
        }
        public void childFormResultOK(string query)
        {
            search_query = query;
            OW.update_movie(listView_movie);
        }
        private void reset()
        {
            textBox_no.Text = "";
            textBox_title.Text = "";
            textBox_director.Text = "";
            textBox_actor.Text = "";
            image = null;
            pictureBox1.Image = image;
            button_update.Enabled = false;
            button_delete.Enabled = false;
        }
        private void listView_movie_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lst = sender as ListView;
            try
            {
                if (lst.SelectedItems != null)
                {
                    ListView.SelectedListViewItemCollection items = lst.SelectedItems;
                    ListViewItem item = items[0];
                    textBox_no.Text = item.Text;
                    textBox_title.Text = item.SubItems[1].Text;
                    textBox_director.Text = item.SubItems[2].Text;
                    textBox_actor.Text = item.SubItems[3].Text;
                    if (item.SubItems[4].Text != "NULL")
                    {
                        byte[] xbytes = new byte[item.SubItems[4].Text.Length / 2];
                        for (int i = 0; i < xbytes.Length; i++)
                        {
                            xbytes[i] = Convert.ToByte(item.SubItems[4].Text.Substring(i * 2, 2), 16);
                        }
                        image = ByteArrayToImage(xbytes);
                        Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                        Image thumnail_img = image.GetThumbnailImage(400, 400, callback, new IntPtr()); //썸네일 만들기
                        pictureBox1.Image = thumnail_img;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    button_update.Enabled = true;
                    button_delete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void button_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"D:\ST\3-2\데이터베이스\Term\movie"; //시작위치 없으면 바탕화면
            dialog.Filter = "Picture Files | *.jpg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file_path = string.Empty;
                file_path = dialog.FileName;
                image = Bitmap.FromFile(file_path);
                Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);//썸네일 만들기
                Image thumnail_img = image.GetThumbnailImage(400, 400, callback, new IntPtr()); //썸네일 만들기
                pictureBox1.Image = thumnail_img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else return;
        }
        private void button_info_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"D:\ST\3-2\데이터베이스\Term\movie"; //시작위치 없으면 바탕화면
            dialog.Filter = "txt Files | *.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string file_path = string.Empty;
                    file_path = dialog.FileName;
                    string text = System.IO.File.ReadAllText(file_path);
                    string[] columns = text.Split(';');
                    textBox_title.Text = columns[0];
                    textBox_director.Text = columns[1];
                    textBox_actor.Text = columns[2];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else return;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Admin.research adminwindow = new Admin.research();
            adminwindow.Owner = this;
            adminwindow.ShowDialog();
        }
        private void comboBox_option_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox lst = sender as ComboBox;
            if (lst.SelectedIndex == 0) { opt_query = " order by 영화번호 asc"; }
            else if (lst.SelectedIndex == 1) { opt_query = " order by 영화번호 desc"; }
            else if (lst.SelectedIndex == 2) { opt_query = " order by 영화제목 asc"; }
            else if (lst.SelectedIndex == 3) { opt_query = " order by 영화제목 desc"; }
            OW.update_movie(listView_movie,search_query,opt_query);
        }
        private void button_re_Click(object sender, EventArgs e)
        {
            comboBox_option.SelectedIndex = 0;
            search_query = "";
            OW.update_movie(listView_movie, search_query, opt_query);
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void button_create_Click(object sender, EventArgs e)
        {
            admin OW = (admin)this.Owner;
            //OW.conn.Open(); //데이터베이스 연결
            try
            {
                OW.conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                if (image == null)
                {
                    cmd.CommandText = "INSERT INTO 영화 VALUES(영화_seq.NEXTVAL,'" + textBox_title.Text + "','" +
                        textBox_director.Text + "', '" + textBox_actor.Text + "', NULL)";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO 영화 VALUES(영화_seq.NEXTVAL,'" + textBox_title.Text + "','" +
                        textBox_director.Text + "', '" + textBox_actor.Text + "', :image_var)";

                    byte[] bytes = imageToByteArray(image);
                    OleDbParameter para = new OleDbParameter();
                    para.OleDbType = OleDbType.LongVarBinary;
                    para.ParameterName = ":image_var";
                    para.Direction = ParameterDirection.Input;
                    para.Size = bytes.Length;
                    para.Value = bytes;
                    cmd.Parameters.Add(para);
                }
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OW.conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                cmd.Parameters.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                reset();
                if (OW.conn != null)
                {
                    OW.conn.Close(); //데이터베이스 연결 해제
                    OW.update_movie(listView_movie, search_query, opt_query);
                }
            }
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            admin OW = (admin)this.Owner;
            //OW.conn.Open(); //데이터베이스 연결
            try
            {
                OW.conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                if (image == null)
                {
                    cmd.CommandText = "UPDATE 영화 SET 영화제목 = '" + textBox_title.Text + "',영화감독 = '" +
                        textBox_director.Text + "',주연배우 = '" + textBox_actor.Text + "', NULL where 영화번호 = " + textBox_no.Text;
                }
                else
                {
                    cmd.CommandText = "UPDATE 영화 SET 영화제목 = '" + textBox_title.Text + "',영화감독 = '" +
                        textBox_director.Text + "',주연배우 = '" + textBox_actor.Text + "',포스터 = :image_var where 영화번호 = " + textBox_no.Text;

                    byte[] bytes = imageToByteArray(image);
                    OleDbParameter para = new OleDbParameter();
                    para.OleDbType = OleDbType.LongVarBinary;
                    para.ParameterName = ":image_var";
                    para.Direction = ParameterDirection.Input;
                    para.Size = bytes.Length;
                    para.Value = bytes;
                    cmd.Parameters.Add(para);
                }
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OW.conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                cmd.Parameters.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (OW.conn != null)
                {
                    OW.conn.Close(); //데이터베이스 연결 해제
                    OW.update_movie(listView_movie, search_query, opt_query);
                }
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            admin OW = (admin)this.Owner;
            //OW.conn.Open(); //데이터베이스 연결
            try
            {
                OW.conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "DELETE FROM 영화 where 영화번호 = " + textBox_no.Text;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OW.conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                reset();
                if (OW.conn != null)
                {
                    OW.conn.Close(); //데이터베이스 연결 해제
                    OW.update_movie(listView_movie, search_query, opt_query);
                }
            }
        }
    }
}
