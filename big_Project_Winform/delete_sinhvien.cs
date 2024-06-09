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
    public partial class delete_sinhvien : Form
    {
        string str_conn;
        string query_con, query_cha;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        public delete_sinhvien()
        {
            InitializeComponent();
        }

        private void delete_sinhvien_Load(object sender, EventArgs e)
        {
            str_conn = @"Data Source=HASHIRAMA\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(str_conn);
            conn.Open();
            //if(conn.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Kết nối thành công");
            //}    
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(xoa.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã sinh viên","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                query_cha = "SELECT * FROM SinhVien WHERE MaSV = @MaSV";
                query_con = "DELETE * FROM DangKyHoc WHERE MaSV = @MaSV";
                cmd = new SqlCommand(query_cha,conn);
                cmd.Parameters.AddWithValue("@MaSV",xoa.Text);
                rdr =cmd.ExecuteReader();          
                if(!rdr.HasRows)
                {
                    MessageBox.Show("Không tồn tại mã sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult xoa_agree = MessageBox.Show("Bạn có chắc muốn xóa sinh viên có mã là: "+xoa.Text, "Xóa sinh viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(xoa_agree == DialogResult.OK)
                    {
                        rdr.Close();

                        string query_con = "DELETE FROM DangKyHoc WHERE MaSV = @MaSV";
                        using (SqlCommand cmd_con = new SqlCommand(query_con, conn))
                        {
                            cmd_con.Parameters.AddWithValue("@MaSV", xoa.Text);
                            cmd_con.ExecuteNonQuery();
                        }

                        string query_cha = "DELETE FROM SinhVien WHERE MaSV = @MaSV";
                        using (SqlCommand cmd_cha = new SqlCommand(query_cha, conn))
                        {
                            cmd_cha.Parameters.AddWithValue("@MaSV", xoa.Text);
                            cmd_cha.ExecuteNonQuery();
                        }
                        MessageBox.Show("Xóa sinh viên thành công", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }    
                conn.Close();
            }    
        }
    }
}
