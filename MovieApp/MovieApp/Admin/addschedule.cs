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
    public partial class addschedule : Form
    {
        admin OWW;
        schedule OW;
        public string date_s;
        public string theater;
        public string opt_query = " order by 영화번호 asc ";
        public string search_query = "";
        DateTime date;
        public addschedule()
        {
            InitializeComponent();
            button_ok.Enabled = false;
        }

        private void addschedule_Load(object sender, EventArgs e)
        {
            OW = (Admin.schedule)this.Owner;
            OWW = (admin)OW.Owner;
            OWW.update_movie(listView_movie, search_query,opt_query);
            date = DateTime.Parse(date_s);
            textBox_date.Text = date.ToString("yyyy-MM-dd");
            textBox_time.Text = date.ToString("HH:mm");
            textBox_theater.Text = theater;
        }
        public void childFormResultOK(string query)
        {
            search_query = query;
            OWW.update_movie(listView_movie,query);
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                OWW.conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OWW.conn;
                cmd.CommandText = "INSERT INTO 상영스케줄 VALUES("+textBox_no.Text+",TO_DATE('"+date.ToString("yyyy-MM-dd HH:mm")+"','yyyy-MM-dd HH24:MI'),'"
                    +theater+"','"+textBox_price.Text+"')";
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
            }
            finally
            {
                OWW.conn.Close();
                OW.refrash();
                this.Dispose();
            }
        }

        private void button_cancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox_price_TextChanged(object sender, EventArgs e)
        {
            if (textBox_price.Text == ""||textBox_no.Text==""){ button_ok.Enabled = false; }
            else { button_ok.Enabled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin.research adminwindow = new Admin.research();
            adminwindow.Owner = this;
            adminwindow.ShowDialog();
        }

        private void button_re_Click(object sender, EventArgs e)
        {
            search_query = "";
            opt_query = " order by 영화번호 asc ";
            OWW.update_movie(listView_movie, search_query, opt_query);
        }
    }
}
