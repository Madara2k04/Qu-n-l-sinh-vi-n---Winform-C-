using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace big_Project_Winform
{
    public partial class Form1 : Form
    {
        string str_conn;
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        string query;
        SqlDataReader reader;
        string gioitinh;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            search_sinhvien.Focus();
            try
            {
                str_conn = @"Data Source=HASHIRAMA\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Encrypt=False";
                conn = new SqlConnection(str_conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //if (conn.State == ConnectionState.Open)
                //{
                //    MessageBox.Show("Kết nối thành công!");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void thoat_chuong_trinh()
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn thoát chương trình không","Thoát chương trình",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(thoat == DialogResult.Yes )
            {
                Application.Exit();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            thoat_chuong_trinh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Add form_Add = new Form_Add();
            form_Add.ShowDialog();
            form_Add = null;
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            full_SinhVien full_SinhVien = new full_SinhVien();
            full_SinhVien.ShowDialog();
            Show();
            full_SinhVien = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            infor_teacher infor_Teacher = new infor_teacher();
            infor_Teacher.ShowDialog();
            Show() ;
            infor_Teacher = null;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if(search_sinhvien.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã sinh viên để tìm kiếm","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                query = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, QueQuan, MaLop FROM SinhVien WHERE MaSV = @MaSV";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", search_sinhvien.Text);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        if (Convert.ToBoolean(reader["GioiTinh"]))
                        {
                            gioitinh = "Nam";
                        }    
                        else if(!Convert.ToBoolean(reader["GioiTinh"]))
                        {
                            gioitinh = "Nữ";
                        }    
                        MessageBox.Show("Mã sinh viên: " + reader["MaSV"].ToString() + "\n" +
                            "Tên sinh viên: " + reader["HoTen"].ToString() + "\n" +
                            "Ngày sinh: " + reader["NgaySinh"].ToString() + "\n" +
                            "Giới tính: " + gioitinh + "\n" +
                            "Quê quán: " + reader["QueQuan"].ToString() + "\n" +
                            "Lớp: " + reader["MaLop"].ToString(), "Thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }    
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (search_giangvien.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã giảng viên để tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                query = "SELECT * FROM GiangVien WHERE MaGV = @MaGV";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGV", search_giangvien.Text);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Mã giảng viên: " + reader["MaGV"].ToString() + "\n" +
                            "Tên giảng viên: " + reader["HoTen"].ToString() + "\n" +
                            "Chuyên ngành giảng dạy: " + reader["MaKhoa"].ToString(), "Thông tin giảng viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã giảng viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            delete_sinhvien delete_Sinhvien = new delete_sinhvien();
            delete_Sinhvien.ShowDialog();
            Show();
            delete_Sinhvien = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            form_sua form_Sua = new form_sua();
            form_Sua.ShowDialog();
            Show();
            form_Sua = null;
        }
    }
}
