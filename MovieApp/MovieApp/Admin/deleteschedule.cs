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
    public partial class deleteschedule : Form
    {
        schedule OW;
        admin OWW;
        public string date_s;
        public string theater;
        public string movie;
        DateTime date;
        
        public deleteschedule()
        {
            InitializeComponent();
        }

        private void deleteschedule_Load(object sender, EventArgs e)
        {
            OW = (Admin.schedule)this.Owner;
            OWW = (admin)OW.Owner;
            date = DateTime.Parse(date_s);
            textBox_date.Text = date.ToString("yyyy-MM-dd");
            textBox_time.Text = date.ToString("HH:mm");
            textBox_theater.Text = theater;
            textBox_no.Text = movie;
            List<List<string>> rst = OWW.find_movie("영화제목", "where 영화번호 = " + movie);
            textBox_title.Text = rst[0][0];
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                OWW.conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OWW.conn;
                cmd.CommandText = "DELETE FROM 상영스케줄 where 영화번호 = " + movie + " and 상영관번호 = " + theater + 
                    " and TO_CHAR(상영시간,'yyyy-MM-dd HH24:MI') = '" + date.ToString("yyyy-MM-dd HH:mm") + "'";
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                OWW.conn.Close();
                OW.refrash();
                this.Dispose();
            }
        }
    }
}
