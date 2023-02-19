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
    public partial class user : Form
    {
        admin OW;
        string CD = "";
        string ID = "";
        string NAME = "";
        string PH = "";
        string GRADE = "";
        string[] grades = { "SILVER", "GOLD", "VIP" };
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            OW = (admin)this.Owner;
            OW.update_user(listView_user, "", " order by 회원번호 asc ");
            txtGRADE.Items.AddRange(grades);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OW.update_wait_user(listView_user);
        }

        private void listView_user_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            ListView lst = sender as ListView;
            try
            {
                if (lst.SelectedItems != null)
                {
                    ListView.SelectedListViewItemCollection items = lst.SelectedItems;
                    ListViewItem item = items[0];
                    txtCD.Text = item.Text;
                    CD = item.Text;
                    txtNAME.Text = item.SubItems[1].Text;
                    NAME = item.SubItems[1].Text;
                    txtID.Text = item.SubItems[2].Text;
                    ID = item.SubItems[2].Text;
                    txtGRADE.SelectedIndex = Array.IndexOf(grades,item.SubItems[3].Text);
                    txtPN.Text = item.SubItems[4].Text;
                    PH = item.SubItems[4].Text;
                    button_update.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                OW.conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OW.conn;
                cmd.CommandText = string.Format("UPDATE 회원 set 등급 = '{0}' where 회원번호 = {1}",txtGRADE.Text, CD);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                OW.conn.Close();
                OW.update_user(listView_user, "", " order by 회원번호 asc ");
            }
        }
    }
}
