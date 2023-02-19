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
    public partial class theater : Form
    {
        admin OW;
        public theater()
        {
            InitializeComponent();
            reset();
        }
        private void reset()
        {
            textBox_no.Text = "";
            comboBox_type.SelectedIndex = -1;
            numericUpDown_row.Value = 0;
            numericUpDown_colunm.Value = 0;
            numericUpDown_group.Value = 0;
            button_update.Enabled = false;
            button_delete.Enabled = false;
        }
        private void theater_Load(object sender, EventArgs e)
        {
            OW = (admin)this.Owner;
            comboBox_type.Items.AddRange(OW.theater_types);
            OW.update_theater(listView_theater);
        }
       
        //버튼 초기화,수정,삭제,추가
        private void button_create_Click(object sender, EventArgs e)
        {
            //OW.conn.Open(); //데이터베이스 연결
            try
            {
                if (comboBox_type.SelectedIndex == -1) { throw new Exception ("상영관 형태를 골라주세요."); }

                int colunm = Decimal.ToInt32(numericUpDown_row.Value);
                int row = Decimal.ToInt32(numericUpDown_colunm.Value);
                int group = Decimal.ToInt32(numericUpDown_group.Value);
                if (colunm == 0 || row == 0 || group == 0) { throw new Exception("좌석이 설정되지 않았습니다."); }

                OW.conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = OW.conn;

                cmd.CommandText = "INSERT INTO 상영관 VALUES('" + textBox_no.Text + "','" + OW.theater_types[comboBox_type.SelectedIndex] + "')";
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                cmd.Parameters.Clear();

                for(int c = 0; c < colunm; c++) 
                {
                    for(int r = 0; r < row; r++)
                    {
                        for(int g = 0; g < group; g++)
                        {
                            cmd.CommandText = "INSERT INTO 상영관좌석 VALUES('" + textBox_no.Text + "','" +
                                        (char)('A' + c) + "','" + (r+1) + "-" + (g+1) + "')";
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                    }
                }

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
                    OW.update_theater(listView_theater);
                }
            }
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            //OW.conn.Open(); //데이터베이스 연결
            try
            {
                if (comboBox_type.SelectedIndex == -1) { throw new Exception("상영관 형태를 골라주세요"); }
                OW.conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = OW.conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM 상영관좌석 where 상영관번호 = '" + textBox_no.Text + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM 상영관 where 상영관번호 = '" + textBox_no.Text + "'";
                cmd.ExecuteNonQuery();
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
                    OW.update_theater(listView_theater);
                }
            }
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            //OW.conn.Open(); //데이터베이스 연결
            try
            {
                if (comboBox_type.SelectedIndex == -1) { throw new Exception("상영관 형태를 골라주세요"); }
                OW.conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "UPDATE 상영관 SET 상영관형태 = '"+OW.theater_types[comboBox_type.SelectedIndex] +
                                        "' where 상영관번호 = " +textBox_no.Text;
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
                    OW.update_theater(listView_theater);
                }
            }
        }
        
        private void listView_theater_MouseDoubleClick(object sender, MouseEventArgs e)//리스트뷰에서 클릭이벤트
        {
            ListView lst = sender as ListView;
            try
            {
                if (lst.SelectedItems != null)
                {
                    ListView.SelectedListViewItemCollection items = lst.SelectedItems;
                    ListViewItem item = items[0];
                    textBox_no.Text = item.SubItems[1].Text;
                    int index = -1;
                    if ((index = Array.IndexOf(OW.theater_types, item.SubItems[2].Text)) == -1)
                    {
                        throw new Exception("올바르지않은 값이 들어가있습니다.");
                    }
                    else { comboBox_type.SelectedIndex = index; }

                    button_update.Enabled = true;
                    button_delete.Enabled = true;

                    OW.conn.Open(); //데이터베이스 연결
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = OW.conn;
                    cmd.CommandText = "select count(DISTINCT 행번호) from 상영관좌석 where 상영관번호 = " + textBox_no.Text;
                    numericUpDown_row.Value = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.CommandText = "select count(*) from 상영관좌석 where 상영관번호 = " + textBox_no.Text + "and 위치번호 like '1-%' group by 행번호";
                    numericUpDown_group.Value = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.CommandText = "select count(*) from 상영관좌석 where 상영관번호 = " + textBox_no.Text + "group by 행번호";
                    numericUpDown_colunm.Value = Convert.ToInt32(cmd.ExecuteScalar()) / numericUpDown_group.Value;
                    OW.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                seat_draw();
            }
        }
        private void seat_draw()
        {
            try
            {
                tableLayoutPanel_seat.Controls.Clear();
                tableLayoutPanel_seat.RowStyles.Clear();
                tableLayoutPanel_seat.ColumnStyles.Clear();

                //tableLayoutPanel_seat.Anchor = (AnchorStyles.Top);
                //seattable.Dock = DockStyle.Fill;

                int row = Decimal.ToInt32(numericUpDown_row.Value);
                int groups = Decimal.ToInt32(numericUpDown_colunm.Value);
                int each_group = Decimal.ToInt32(numericUpDown_group.Value);
                int colunm = (each_group * groups) + (groups - 1);
                int square = 0;

                if (row > colunm) { square = row; }
                else { square = colunm; }
                int H = (panel_seat.Height - 80 - 10) / square;
                int W = (panel_seat.Width - 20) / square;
                tableLayoutPanel_seat.Width = W * square;
                tableLayoutPanel_seat.Height = H * square;
                tableLayoutPanel_seat.ColumnCount = square;
                tableLayoutPanel_seat.RowCount = square;
                tableLayoutPanel_seat.Location = new Point((panel_seat.Width - (W * square)) / 2, 80);

                for (int i = 0; i < square; i++) { tableLayoutPanel_seat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, H)); }
                for (int i = 0; i < square; i++) { tableLayoutPanel_seat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, W)); }

                for (int r = 0; r < row; r++)
                {
                    int count = 0;
                    for (int c = 0; c < colunm; c++)
                    {
                        Label seat = new Label();
                        seat.Text = "";
                        seat.Dock = DockStyle.Fill;
                        seat.Margin = new Padding(1, 1, 1, 1);
                        seat.Anchor = AnchorStyles.Top;
                        seat.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel_seat.Controls.Add(seat, c, r);
                        if (count != each_group) { seat.BorderStyle = BorderStyle.FixedSingle; count++; }
                        else { count = 0; }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error :" + ex.Message);
            }
            
        }
        private void panel_seat_Paint(object sender, PaintEventArgs e)//윤각선그리기
        {
            Panel lst = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, lst.ClientRectangle,
                Color.Black, 2, ButtonBorderStyle.Solid,
                Color.Black, 2, ButtonBorderStyle.Solid,
                Color.Black, 2, ButtonBorderStyle.Solid,
                Color.Black, 2, ButtonBorderStyle.Solid);
        } 
        
        //행열블럭 조작
        private void numericUpDown_row_ValueChanged(object sender, EventArgs e)
        {
            seat_draw();
        }
        private void numericUpDown_colunm_ValueChanged(object sender, EventArgs e)
        {
            seat_draw();
        }
        private void numericUpDown_group_ValueChanged(object sender, EventArgs e)
        {
            seat_draw();
        }
    }
}
