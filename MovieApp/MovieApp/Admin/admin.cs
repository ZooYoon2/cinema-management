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
    public partial class admin : Form
    {
        public OleDbConnection conn;
        public string connectionString = "Provider=OraOLEDB.Oracle;Password= 1234; User ID=movieapp";
        public string[] theater_types = { "2D", "3D", "X-Screen" };
        bool start = false;
        Form frame;
        public admin()
        {
            InitializeComponent();
            //연결 스트링에 대한 정보 
            //Oracle - MSDAORA 
            conn = new OleDbConnection(connectionString);
        }
        public void putForm(Form Page)
        {
            try
            {
                if (start) { frame.Close(); }
                else { start = true; }
                Page.Owner = this;
                Page.TopLevel = false;
                mainscreen.Controls.Add(Page);
                Page.Show();
                Page.Dock = DockStyle.Fill;
                frame = Page;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }
        }
        public void update_theater(ListView listview,string opt_query="order by 상영관번호 asc")
        {
            try
            {
                conn.Open();
                //OW.conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.CommandText = "select * from 상영관 "+opt_query; //member 테이블
                OleDbDataReader read = cmd.ExecuteReader(); //select * from emp 결과
                listview.View = View.Details;
                listview.GridLines = true;
                listview.FullRowSelect = true;

                //필드명 받아오는 반복문
                listview.Columns.Clear();
                listview.Columns.Add("", 0);
                listview.Columns.Add(read.GetName(0), 70, HorizontalAlignment.Center);
                listview.Columns.Add(read.GetName(1), 90, HorizontalAlignment.Center);
                listview.Columns.Add("좌석수", 50, HorizontalAlignment.Center);
                //행 단위로 반복
                listview.Items.Clear();
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd2.Connection = conn;
                while (read.Read())
                {
                    String[] item = new String[listview.Columns.Count]; // 필드수만큼 오브젝트 배열
                    item[1] = read.GetValue(0).ToString();//상영관번호
                    item[2] = read.GetValue(1).ToString();//상영관형태
                    cmd2.CommandText = "select count(*) from 상영관좌석 where 상영관번호 = '" + item[1]+"'";
                    item[3] = Convert.ToString(cmd2.ExecuteScalar());
                    listview.Items.Add(new ListViewItem(item)); //데이터그리드뷰에 오브젝트 배열 추가
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close(); //데이터베이스 연결 해제
                }
            }
        }
        public void update_movie(ListView listView, string search_query = "", string opt_query ="")
        {
            try
            {
                conn.Open();
                //OW.conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from 영화" + search_query + opt_query; //member 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select * from emp 결과
                listView.View = View.Details;
                listView.GridLines = true;
                listView.FullRowSelect = true;

                //필드명 받아오는 반복문
                listView.Columns.Clear();
                for (int i = 0; i < read.FieldCount; i++)
                {
                    listView.Columns.Add(read.GetName(i));
                }

                //행 단위로 반복
                listView.Items.Clear();
                while (read.Read())
                {
                    String[] item = new String[read.FieldCount]; // 필드수만큼 오브젝트 배열
                    item[0] = read.GetValue(0).ToString();//영화번호
                    item[1] = read.GetValue(1).ToString();//영화제목
                    item[2] = read.GetValue(2).ToString();//영화감독
                    item[3] = read.GetValue(3).ToString();//영화배우
                    if (read.IsDBNull(4) == false)//null값이 아니라면
                    {
                        item[4] = string.Concat(Array.ConvertAll((byte[])read.GetValue(4), byt => byt.ToString("X2")));
                    }
                    else { item[4] = "NULL"; }
                    listView.Items.Add(new ListViewItem(item)); //데이터그리드뷰에 오브젝트 배열 추가
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close(); //데이터베이스 연결 해제
                }
            }
        }
        public void update_wait_user(ListView listView, string search_query = "", string opt_query = "")
        {
            try
            {
                conn.Open();
                //OW.conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from 승인대기회원" + search_query + opt_query; //member 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select * from emp 결과
                listView.View = View.Details;
                listView.GridLines = true;
                listView.FullRowSelect = true;

                //필드명 받아오는 반복문
                listView.Columns.Clear();
                for (int i = 0; i < read.FieldCount; i++)
                {
                    listView.Columns.Add(read.GetName(i),100);
                }

                //행 단위로 반복
                listView.Items.Clear();
                while (read.Read())
                {
                    String[] item = new String[read.FieldCount]; // 필드수만큼 오브젝트 배열
                    item[0] = read.GetValue(0).ToString();//회원이름
                    item[1] = read.GetValue(1).ToString();//회원아이디
                    item[2] = read.GetValue(2).ToString();//회원비밀번호
                    item[3] = read.GetValue(3).ToString();//휴대전화
                    item[4] = read.GetValue(4).ToString();//카드번호
                    listView.Items.Add(new ListViewItem(item)); //데이터그리드뷰에 오브젝트 배열 추가
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close(); //데이터베이스 연결 해제
                }
            }
        }
        public void update_user(ListView listView, string search_query = "", string opt_query = "")
        {
            try
            {
                conn.Open();
                //OW.conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 회원번호, 회원이름, 회원아이디, 등급, 휴대전화 from 회원" + search_query + opt_query; //member 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select * from emp 결과
                listView.View = View.Details;
                listView.GridLines = true;
                listView.FullRowSelect = true;

                //필드명 받아오는 반복문
                listView.Columns.Clear();
                for (int i = 0; i < read.FieldCount; i++)
                {
                    listView.Columns.Add(read.GetName(i), 100);
                }

                //행 단위로 반복
                listView.Items.Clear();
                while (read.Read())
                {
                    if (Int32.Parse(read.GetValue(0).ToString()) != -1) {
                        String[] item = new String[read.FieldCount]; // 필드수만큼 오브젝트 배열
                        item[0] = read.GetValue(0).ToString();//회원번호
                        item[1] = read.GetValue(1).ToString();//회원이름
                        item[2] = read.GetValue(2).ToString();//회원아이디
                        item[3] = read.GetValue(3).ToString();//휴대등급
                        item[4] = read.GetValue(4).ToString();//휴대전화
                        listView.Items.Add(new ListViewItem(item)); //데이터그리드뷰에 오브젝트 배열 추가
                    }
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close(); //데이터베이스 연결 해제
                }
            }
        }
        public List<List<string>> find_movie(string find_colunm = "*", string search_query = "")
        {
            List<List<string>> result = new List<List<string>>();
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.CommandText = "select " + find_colunm + " from 영화 " + search_query;
                OleDbDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    int col = read.FieldCount;
                    List<string> row = new List<string>();
                    for(int i = 0; i < col; i++)
                    {
                        row.Add(read.GetValue(i).ToString());
                    }
                    result.Add(row);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
            finally {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            putForm(new Admin.movies());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            putForm(new Admin.theater());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            putForm(new Admin.schedule());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            putForm(new Admin.waituser());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            putForm(new Admin.user());
        }
    }
}
