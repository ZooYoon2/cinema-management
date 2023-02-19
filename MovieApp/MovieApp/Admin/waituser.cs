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
    public partial class waituser : Form
    {
        admin OW;
        string ID="";
        string NAME = "";
        string PW = "";
        string PH = "";
        string GRADE = "";
        string CARD = "";
        public waituser()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            OW = (admin)this.Owner;
            OW.update_wait_user(listView_user);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OW.conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OW.conn;
                cmd.CommandText = string.Format("insert into 회원 values(회원_seq.NEXTVAL,'{0}','{1}','{2}','{3}','{4}','{5}')"
                    ,ID,PW,NAME,PH,txtGRADE.Text,CARD);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = string.Format("DELETE FROM 승인대기회원 where 회원아이디 = '{0}'", ID);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                OW.conn.Close();
                OW.update_wait_user(listView_user);
            }
        }

        private void listView_user_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lst = sender as ListView;
            try
            {
                if (lst.SelectedItems != null)
                {
                    ListView.SelectedListViewItemCollection items = lst.SelectedItems;
                    ListViewItem item = items[0];
                    txtNAME.Text = item.Text;
                    NAME = item.Text;
                    txtID.Text = item.SubItems[1].Text;
                    ID = item.SubItems[1].Text;
                    txtPN.Text = item.SubItems[3].Text;
                    PW = item.SubItems[2].Text;
                    PH = item.SubItems[3].Text;
                    CARD = item.SubItems[4].Text;
                    button_update.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OW.update_wait_user(listView_user);
        }
    }
}
