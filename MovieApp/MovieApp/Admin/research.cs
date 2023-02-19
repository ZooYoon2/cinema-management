using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp.Admin
{
    public partial class research : Form
    {
        public research()
        {
            InitializeComponent();
        }

        private void button_cancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Q = new Dictionary<string, string>();
            Q.Add("영화제목",textBox_title.Text);
            Q.Add("영화감독",textBox_director.Text);
            Q.Add("주연배우",textBox_actor.Text);

            int count = 0;
            string query = "";
            foreach (KeyValuePair<string,string> q in Q)
            {
                if (!string.IsNullOrWhiteSpace(q.Value))
                {
                    if (count == 0) { query += " where " + q.Key + " like '%" + q.Value + "%'"; count++; }
                    else { query += " and " + q.Key + " like '%" + q.Value + "%'"; }
                }
            }
            if (this.Owner.Name == "moves")
            {
                Admin.movies OW = (Admin.movies)this.Owner;
                OW.childFormResultOK(query);
            }
            else if (this.Owner.Name == "addschedule")
            {
                Admin.addschedule OW = (Admin.addschedule)this.Owner;
                OW.childFormResultOK(query);
            }
            
            this.Dispose();
        }
    }
}
