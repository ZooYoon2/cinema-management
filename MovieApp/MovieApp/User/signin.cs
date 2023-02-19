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
using System.Security.Cryptography;

namespace MovieApp.User
{
    public partial class signin : Form
    {
        main OW;
        public signin()
        {
            InitializeComponent();
        }

        private void B_signup_Click(object sender, EventArgs e)
        {
            OW.putForm(new signup(),true);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Exception idpwerror = new Exception("아이디/비밀번호를 잘못입력하셨습니다");
            try
            {
                OW.userconn.Open(); //데이터베이스 연결

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 회원번호, 회원아이디, 회원비밀번호, 회원이름 from 회원 where 회원아이디 ='" + ID.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = OW.userconn;

                OleDbDataReader read = cmd.ExecuteReader(); //select 회원ID from 회원 결과

           

                if (!(read.Read()))
                    throw idpwerror;
                else
                {
                    string tcd = read.GetValue(0).ToString();
                    if (Int32.Parse(tcd) == -1)
                    {
                        read.Close();
                        Admin.admin adminwindow = new Admin.admin();
                        adminwindow.Show();
                    }
                    string input_value = PW.Text;

                    // SHA256 해시 생성
                    SHA256 hash1 = new SHA256Managed();
                    byte[] bytes1 = hash1.ComputeHash(Encoding.ASCII.GetBytes(input_value));

                    // 16진수 형태로 문자열 결합
                    StringBuilder sb1 = new StringBuilder();
                    foreach (byte b1 in bytes1)
                        sb1.AppendFormat("{0:x2}", b1);

                    // 입력값의 해시결과
                    String hash_value = sb1.ToString();

                    if (read.GetValue(2).ToString() != hash_value)
                    {
                        throw idpwerror;
                    }
                }
                string id = read.GetValue(1).ToString();
                string cd = read.GetValue(0).ToString();
                string name = read.GetValue(3).ToString();
                read.Close();
                if(Int32.Parse(cd) == -1)
                {
                    Admin.admin adminwindow = new Admin.admin();
                    adminwindow.Show();
                }
                else
                {
                    MessageBox.Show(string.Format("{0}님 환영합니다", name));
                    OW.login(id, cd, name);
                    if (OW.savepages.Count != 0)
                    {
                        OW.backForm();
                    }
                    else { OW.putForm(new home()); }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //에러 메세지 
            }
            finally
            {
                OW.userconn.Close();
            }
        }

        private void signin_Load(object sender, EventArgs e)
        {
            OW = (main)this.Owner;
            PW.PasswordChar = '*';
        }
    }
}
