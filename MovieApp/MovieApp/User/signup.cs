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
    public partial class signup : Form
    {
        bool idcheck = false;
        main OW;
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            OW = (main)this.Owner;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtPW.Text.Length < 2)
            {
                MessageBox.Show("Pass Word는 3자 이상이어야 합니다");
                return;
            }
            if (!idcheck)
            {
                MessageBox.Show("ID 중복확인을 해주세요");
                return;
            }
            try
            {
                string phonenumber = string.Format("{0}{1}{2}",PN1.Text,PN2.Text,PN3.Text);
                string cardnumber = CARD1.Text + CARD2.Text + CARD3.Text + CARD4.Text;
                string value = txtPW.Text;

                // SHA256 해시 생성
                SHA256 hash = new SHA256Managed();
                byte[] bytes = hash.ComputeHash(Encoding.ASCII.GetBytes(value));

                // 16진수 형태로 문자열 결합
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.AppendFormat("{0:x2}", b);

                // 문자열 출력
                String password = sb.ToString();
                OW.userconn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = string.Format("INSERT INTO 승인대기회원 VALUES('{0}','{1}','{2}','{3}','{4}')"
                    ,txtName.Text,txtID.Text, password,phonenumber, cardnumber);

                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = OW.userconn;

                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                MessageBox.Show("가입이 완료되었습니다.\n 승인후 사용이 가능합니다.");
                OW.backForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (OW.userconn != null)
                {
                    OW.userconn.Close(); //데이터베이스 연결 해제
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Length < 3)
                {
                    MessageBox.Show("ID는 3자 이상이어야 합니다");
                    idcheck = false;
                    return;
                }

                OW.userconn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = OW.userconn;

                cmd.CommandText = "select * from 회원 where 회원아이디 ='" + txtID.Text + "'";
                OleDbDataReader read = cmd.ExecuteReader(); //select 회원ID from 회원 결과
                bool A = read.Read();
                read.Close();
                cmd.CommandText = "select * from 승인대기회원 where 회원아이디 ='" + txtID.Text + "'";
                read = cmd.ExecuteReader();
                bool B = read.Read();
                read.Close();
                if (!A&&!B)
                {
                    idcheck = true;
                    MessageBox.Show("사용가능한 ID입니다"); //에러 메세지 
                }
                else
                {
                    MessageBox.Show("중복 ID입니다"); //에러 메세지 
                }
                OW.userconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OW.backForm();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
