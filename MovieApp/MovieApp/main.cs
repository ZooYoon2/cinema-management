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

namespace MovieApp
{
    public partial class main : Form
    {
        bool start = false;
        Form frame;
        public Stack<Form> savepages = new Stack<Form>();
        //설정
        public OleDbConnection userconn;
        public string connectionString = "Provider=OraOLEDB.Oracle;Password= 1234; User ID=movieapp";
        string USERID = "";
        string USERNAME = "";
        public string USERCD = "";
        public bool b_USER = false;

        public main()
        {
            InitializeComponent();
            putForm(new User.home());
            userconn = new OleDbConnection(connectionString);
        }
        public void putForm(Form Page,bool savepage = false)
        {
            try
            {
                if (!savepage)
                {
                    if (start) { frame.Close(); }
                    else { start = true; }
                    Page.Owner = this;
                    Page.TopLevel = false;
                    mainscreen.Controls.Add(Page);
                    Page.Show();
                    Page.Dock = DockStyle.Fill;
                    frame = Page;
                    if (Page.Owner == null) { MessageBox.Show("this에러"); }
                }
                else
                {
                    savepages.Push(frame);
                    frame.Hide();
                    Page.Owner = this;
                    Page.TopLevel = false;
                    mainscreen.Controls.Add(Page);
                    Page.Show();
                    Page.Dock = DockStyle.Fill;
                    frame = Page;
                    if (Page.Owner == null) { MessageBox.Show("this에러"); }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }
        }
        public void backForm()
        {
            frame.Close();
            frame = savepages.Pop();
            frame.Show();
        }
        public void deleteForm()
        {
            savepages.Clear();
        }
        private void B_home_Click(object sender, EventArgs e)
        {
            deleteForm();
            putForm(new User.home());
        }
        private void B_movies_Click(object sender, EventArgs e)
        {
            deleteForm();
            putForm(new User.moviechart());
        }
        private void B_signin_Click(object sender, EventArgs e)
        {
            deleteForm();
            putForm(new User.signin());
        }
        private void B_ticket_Click(object sender, EventArgs e)
        {
            deleteForm();
            putForm(new User.ticket());
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(190, Color.Black);
            e.Graphics.DrawLine(new Pen(Color.White, 1), 0, 80, panel1.Width, 80);
        }
        public void login(string ID, string CD, string NAME)
        {
            USERID = ID;
            USERCD = CD;
            USERNAME = NAME;
            b_USER = true;
            panel_user.Controls.Clear();
            Label user = new Label();
            user.Text = string.Format("{0}님",USERNAME);
            user.Dock = DockStyle.Top;
            user.TextAlign = ContentAlignment.MiddleCenter;
            Button logout = new Button();
            logout.Text = "로그아웃";
            logout.Font = new Font("나눔고딕", 9);
            logout.Dock = DockStyle.Bottom;
            logout.Click += logout_Click;
            panel_user.Controls.Add(logout);
            panel_user.Controls.Add(user);
        }
        private void logout_Click(object sender, EventArgs e) { logout(); }
        private void logout()
        {
            USERID = "";
            USERCD = "";
            USERNAME = "";
            b_USER = false;
            panel_user.Controls.Clear();
            Button login = new Button();
            login.Size = new Size(100, 50);
            login.Font = new Font("나눔고딕", 16, FontStyle.Bold);
            login.FlatStyle = FlatStyle.Flat;
            login.Anchor = AnchorStyles.Top;
            login.Text = "로그인";
            login.Click += B_signin_Click;
            login.FlatAppearance.BorderSize = 0;
            panel_user.Controls.Add(login);
        }
        private void main_Load(object sender, EventArgs e)
        {
            logout();
        }
        public List<List<string>> find_movie(string find_colunm = "*", string search_query = "")
        {
            List<List<string>> result = new List<List<string>>();
            try
            {
                userconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = userconn;
                cmd.CommandText = "select " + find_colunm + " from 영화 " + search_query;
                OleDbDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    int col = read.FieldCount;
                    List<string> row = new List<string>();
                    for (int i = 0; i < col; i++)
                    {
                        row.Add(read.GetValue(i).ToString());
                    }
                    result.Add(row);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                if (userconn != null)
                {
                    userconn.Close();
                }
            }
            return result;
        }
        public List<List<string>> find_theater(string find_colunm = "*", string search_query = "")
        {
            List<List<string>> result = new List<List<string>>();
            try
            {
                userconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = userconn;
                cmd.CommandText = "select " + find_colunm + " from 상영관 " + search_query + " order by 상영관번호 asc";
                OleDbDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    int col = read.FieldCount;
                    List<string> row = new List<string>();
                    for (int i = 0; i < col; i++)
                    {
                        row.Add(read.GetValue(i).ToString());
                    }
                    result.Add(row);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                if (userconn != null)
                {
                    userconn.Close();
                }
            }
            return result;
        }
        public List<List<string>> find_seat(string find_colunm = "*", string search_query = "")
        {
            List<List<string>> result = new List<List<string>>();
            try
            {
                userconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = userconn;
                cmd.CommandText = "select " + find_colunm + " from 상영관좌석 " + search_query;
                OleDbDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    int col = read.FieldCount;
                    List<string> row = new List<string>();
                    for (int i = 0; i < col; i++)
                    {
                        row.Add(read.GetValue(i).ToString());
                    }
                    result.Add(row);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                if (userconn != null)
                {
                    userconn.Close();
                }
            }
            return result;
        }
        public List<List<string>> find_schedule(string find_colunm = "*", string search_query = "")
        {
            List<List<string>> result = new List<List<string>>();
            try
            {
                userconn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = userconn;
                cmd.CommandText = "select " + find_colunm + " from 상영스케줄 " + search_query;
                OleDbDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    int col = read.FieldCount;
                    List<string> row = new List<string>();
                    for (int i = 0; i < col; i++)
                    {
                        row.Add(read.GetValue(i).ToString());
                    }
                    result.Add(row);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally
            {
                if (userconn != null)
                {
                    userconn.Close();
                }
            }
            return result;
        }
    }
}
